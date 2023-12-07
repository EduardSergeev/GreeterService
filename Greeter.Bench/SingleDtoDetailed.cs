using System.Text.Json;
using BenchmarkDotNet.Attributes;
using Google.Protobuf;

using Dto = Greeter.Common.Person;
using Proto = Greeter.Common.Grpc.Person;


[MemoryDiagnoser]
[RPlotExporter]
public class SingleDtoDetailed
{
    private static readonly Dto Dto = new GreeterExtendedServiceArbitraryGens().GenGreeterCommonPerson().Last();
    private static readonly Proto Proto = Dto;
    private static readonly byte[] ProtoBytes = Proto.Serialize();
    private static readonly byte[] JsonBytes = JsonSerializer.SerializeToUtf8Bytes(Dto);
    private readonly MemoryStream Stream = new();
    private readonly CodedOutputStream ProtoStream;

    public SingleDtoDetailed()
    {
        ProtoStream = new(Stream);
    }

    [Benchmark(Description = "DTO → Proto")]
    [BenchmarkCategory("ToBinary")]
    public Proto DtoToProto()
    {
        return Dto;
    }

    [Benchmark(Description = "Proto → byte[]")]
    [BenchmarkCategory("ToBinary")]
    public void ProtoToBinary()
    {
        Proto.WriteTo(ProtoStream);
        ProtoStream.Flush();
        Stream.Position = 0;
    }

    [Benchmark(Description = "byte[] → Proto")]
    [BenchmarkCategory("ToDto")]
    public Proto BinaryToProto()
    {
        return Proto.Parser.ParseFrom(ProtoBytes);
    }

    [Benchmark(Description = "Proto → DTO")]
    [BenchmarkCategory("ToDto")]
    public Dto ProtoToDto()
    {
        return Proto;
    }
}
