using System.Text.Json;
using BenchmarkDotNet.Attributes;
using Google.Protobuf;

using Dto = Greeter.Common.Person;
using Proto = Greeter.Common.Grpc.Person;


[MemoryDiagnoser]
[RPlotExporter]
public class Collections
{
    private static readonly GreeterExtendedServiceArbitraryGens Gens = new();
    private readonly MemoryStream Stream = new();
    private readonly CodedOutputStream ProtoStream;
    private Dto Dto;
    private Proto? Proto;
    private byte[]? ProtoBytes;
    private byte[]? JsonBytes;

    public Collections()
    {
        ProtoStream = new(Stream);
    }

    [Params(1, 10, 100)]
    public int Size { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        Dto = Gens.GenGreeterCommonPerson().Last() with
        {
            OtherNames = Gens.GenGreeterCommonName().Cycle().Take(Size).ToList(),
            Details = Gens.GenGreeterCommonDetails().Last() with
            {
                Addresses = Gens.GenGreeterCommonAddress().Cycle().Take(Size).ToArray()
            }
        };
        Proto = Dto;
        ProtoBytes = Proto.Serialize();
        JsonBytes = JsonSerializer.SerializeToUtf8Bytes(Dto);
    }

    [Benchmark(Description = "DTO → byte[]")]
    [BenchmarkCategory("ToBinary")]
    public void DtoToBinary()
    {
        ((Proto)Dto).WriteTo(ProtoStream);
        ProtoStream.Flush();
        Stream.Position = 0;
    }

    [Benchmark(Description = "DTO → JSON")]
    [BenchmarkCategory("ToBinary")]
    public void DtoToJson()
    {
        JsonSerializer.Serialize(Stream, Dto);
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
