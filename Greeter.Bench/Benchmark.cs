using System.Text.Json;
using BenchmarkDotNet.Attributes;
using Google.Protobuf;
using Greeter.Common.Test;

using Dto = Greeter.Common.Person;
using Proto = Greeter.Common.Grpc.Person;

namespace Greeter.Bench;

[MemoryDiagnoser]
[RPlotExporter]
public class Benchmark
{
    private static readonly GreeterExtendedServiceArbitrary.GreeterExtendedServiceArbitraryGens Gens = new();
    private static readonly Dto Dto = Gens.GenGreeterCommonPerson().MaxBy(p => Serialize((Proto)p).Length);
    private static readonly Proto Proto = Dto;
    private static readonly byte[] ProtoBytes = Serialize(Proto);
    private static readonly byte[] JsonBytes = JsonSerializer.SerializeToUtf8Bytes(Dto);


    private MemoryStream Stream;

    private CodedOutputStream ProtoStream;


    public Benchmark()
    {
        Stream = new();
        ProtoStream = new(Stream);
    }


    private static byte[] Serialize(IMessage message)
    {
        using var stream = new MemoryStream();
        message.WriteTo(stream);
        return stream.ToArray();
    }


    [Benchmark]
    public Proto DtoToProto()
    {
        return Dto;
    }

    [Benchmark]
    public void ProtoSerialize()
    {
        Proto.WriteTo(ProtoStream);
        Stream.Position = 0;
    }

    [Benchmark]
    public void DtoSerialize()
    {
        ((Proto)Dto).WriteTo(ProtoStream);
        Stream.Position = 0;
    }


    [Benchmark]
    public Proto ProtoDeserialize()
    {
        return Proto.Parser.ParseFrom(ProtoBytes);
    }

    [Benchmark]
    public Dto ProtoToDto()
    {
        return Proto;
    }

    [Benchmark]
    public Dto DtoDeserialize()
    {
        return Proto.Parser.ParseFrom(ProtoBytes);
    }


    [Benchmark]
    public void JsonSerialize()
    {
        JsonSerializer.Serialize(Stream, Dto);
        Stream.Position = 0;
    }

    [Benchmark]
    public Dto JsonDeserialize()
    {
        return JsonSerializer.Deserialize<Dto>(JsonBytes);
    }
}
