using System.Text.Json;
using BenchmarkDotNet.Attributes;
using Google.Protobuf;

using Dto = Greeter.Common.StringArray;
using Proto = Greeter.Common.Grpc.StringArray;
using NullableDto = Greeter.Common.NullableStringArray;
using NullableProto = Greeter.Common.Grpc.NullableStringArray;


[MemoryDiagnoser]
[RPlotExporter]
public class StringArraySerialisation
{
    private Dto Dto;
    private NullableDto NullableDto;
    private MemoryStream Stream = new();
    private CodedOutputStream ProtoStream;

    public StringArraySerialisation()
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
    }

    [Benchmark(Description = "string[] → byte[]")]
    [BenchmarkCategory("ToBinary")]
    public void ArrayToBinary()
    {
        ((Proto)Dto).WriteTo(ProtoStream);
        ProtoStream.Flush();
        Stream.Position = 0;
    }

    [Benchmark(Description = "string?[] → byte[]")]
    [BenchmarkCategory("ToBinary")]
    public void NullableArrayToBinary()
    {
        ((NullableProto)NullableDto).WriteTo(ProtoStream);
        ProtoStream.Flush();
        Stream.Position = 0;
    }

    [Benchmark(Description = "string?[] → JSON", Baseline = true)]
    [BenchmarkCategory("ToBinary")]
    public void NullableArrayToJson()
    {
        JsonSerializer.Serialize(Stream, NullableDto);
        Stream.Position = 0;
    }
}
