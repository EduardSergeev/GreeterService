using BenchmarkDotNet.Attributes;
using Google.Protobuf;

using Dto = Greeter.Common.StringArray;
using Proto = Greeter.Common.Grpc.StringArray;
using NullableDto = Greeter.Common.NullableStringArray;
using NullableProto = Greeter.Common.Grpc.NullableStringArray;


[MemoryDiagnoser]
[RPlotExporter]
public class StringArrayDetailed
{
    private readonly MemoryStream Stream = new();
    private readonly CodedOutputStream ProtoStream;
    private Dto Dto;
    private NullableDto NullableDto;
    private Proto? Proto;
    private NullableProto? NullableProto;
    private byte[]? ProtoBytes;

    public StringArrayDetailed()
    {
        ProtoStream = new(Stream);
    }

    [Params(1, 10, 100)]
    public int Size { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        Dto = new Dto
        {
            Items = Enumerable.Range(0, Size).Select(i => new string((char)(i + ' '), i)).ToArray()
        };
        NullableDto = new NullableDto
        {
            Items = Enumerable.Range(0, Size - 1).Select(i => new string((char)(i + ' '), i)).Prepend(null).ToArray()
        };
        Proto = Dto;
        NullableProto = NullableDto;
        ProtoBytes = Proto.Serialize();
    }

    [Benchmark(Description = "string[] → Proto")]
    [BenchmarkCategory("ToBinary")]
    public Proto DtoToProto()
    {
        return Dto;
    }

    [Benchmark(Description = "Proto → byte[]")]
    [BenchmarkCategory("ToBinary")]
    public void ProtoToBinary()
    {
        Proto!.WriteTo(ProtoStream);
        ProtoStream.Flush();
        Stream.Position = 0;
    }

    [Benchmark(Description = "byte[] → Proto")]
    [BenchmarkCategory("ToDto")]
    public Proto BinaryToProto()
    {
        return Proto.Parser.ParseFrom(ProtoBytes);
    }

    [Benchmark(Description = "Proto → string[]")]
    [BenchmarkCategory("ToDto")]
    public Dto ProtoToDto()
    {
        return Proto;
    }
}
