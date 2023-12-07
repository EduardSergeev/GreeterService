using System.Text.Json;
using BenchmarkDotNet.Attributes;
using Google.Protobuf;

using Dto = Greeter.Common.StringArray;
using Proto = Greeter.Common.Grpc.StringArray;
using NullableDto = Greeter.Common.NullableStringArray;
using NullableProto = Greeter.Common.Grpc.NullableStringArray;


[MemoryDiagnoser]
[RPlotExporter]
public class StringArrayDeserialisation
{
    private Dto Dto;
    private NullableDto NullableDto;
    private byte[]? ProtoBytes;
    private byte[]? NullableProtoBytes;
    private byte[]? JsonBytes;
    private readonly MemoryStream Stream = new();
    private readonly CodedOutputStream ProtoStream;

    public StringArrayDeserialisation()
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
        ProtoBytes = ((Proto)Dto).Serialize();
        NullableProtoBytes = ((NullableProto)NullableDto).Serialize();
        JsonBytes = JsonSerializer.SerializeToUtf8Bytes(NullableDto);
    }

    [Benchmark(Description = "byte[] → string[]")]
    [BenchmarkCategory("ToDto")]
    public Dto BinaryToArray()
    {
        return Proto.Parser.ParseFrom(ProtoBytes);
    }

    [Benchmark(Description = "byte[] → string?[]")]
    [BenchmarkCategory("ToDto")]
    public NullableDto BinaryToNullableArray()
    {
        return NullableProto.Parser.ParseFrom(NullableProtoBytes);
    }

    [Benchmark(Description = "JSON → string?[]", Baseline = true)]
    [BenchmarkCategory("ToDto")]
    public NullableDto JsonToNullableArray()
    {
        return JsonSerializer.Deserialize<NullableDto>(JsonBytes);
    }
}
