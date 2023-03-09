using System.Text.Json;
using BenchmarkDotNet.Attributes;
using Google.Protobuf;
using Greeter.Common;
using static Greeter.Common.Title;

using Dto = Greeter.Common.Person;
using Proto = Greeter.Common.Grpc.Person;

// using Dto = Greeter.Common.Address;
// using Proto = Greeter.Common.Grpc.Address;

namespace Greeter.Bench;

[MemoryDiagnoser]
[RPlotExporter]
public class Benchmark
{
    private static readonly Dto Dto = new Dto
    {
        Name = new()
        {
            Title = Mr,
            FirstName = "Eric",
            LastName = "Cartman",
        },
        OtherNames = new()
        {
            new(Miss, "Erica", "Cartman"),
            new(Miss, "Mitch", "Conner"),
        },
        Aliases = new[]
        {
            "The Coon",
            "A.W.E.S.O.M.-O 4000",
        },
        Details = new()
        {
            DateOfBirth = new(DateTime.Now.Year - 10, 7, 1),
            Height = 5.5,
            Length = 1.4M,
            Addresses = new Address[]
            {
                new()
                {
                    Street = new[] { "28201 E. Bonanza St." },
                    City = "South Park",
                    State = "Colorado",
                    Country = "USA",
                },
            },
        }
    };

    // private static readonly Dto Dto = new Dto
    // {
    //     Street = "221B Baker Street",
    //     City = "London",
    //     Postcode = 90210,
    // };


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
