using System.Text.Json;
using BenchmarkDotNet.Attributes;
using Google.Protobuf;

using Dto = Greeter.Common.Person;
using Proto = Greeter.Common.Grpc.Person;


[MemoryDiagnoser]
[RPlotExporter]
public class SingleDto
{
    private static readonly Dto Data = new GreeterExtendedServiceArbitraryGens().GenGreeterCommonPerson().Last();
    private static readonly Proto Proto = Data;
    private static readonly byte[] ProtoBytes = Proto.Serialize();
    private static readonly byte[] JsonBytes = JsonSerializer.SerializeToUtf8Bytes(Data);
    private readonly MemoryStream Stream = new();
    private readonly CodedOutputStream ProtoStream;

    public SingleDto()
    {
        ProtoStream = new(Stream);
    }

    [Benchmark(Description = "DTO → byte[]")]
    [BenchmarkCategory("ToBinary")]
    public void DtoToBinary()
    {
        ((Proto)Data).WriteTo(ProtoStream);
        ProtoStream.Flush();
        Stream.Position = 0;
    }

    [Benchmark(Description = "DTO → JSON")]
    [BenchmarkCategory("ToBinary")]
    public void DtoToJson()
    {
        JsonSerializer.Serialize(Stream, Data);
        Stream.Position = 0;
    }

    [Benchmark(Description = "byte[] → DTO")]
    [BenchmarkCategory("ToDto")]
    public Dto BinaryToDto()
    {
        return Proto.Parser.ParseFrom(ProtoBytes);
    }

    [Benchmark(Description = "JSON → DTO")]
    [BenchmarkCategory("ToDto")]
    public Dto JsonToDto()
    {
        return JsonSerializer.Deserialize<Dto>(JsonBytes);
    }
}
