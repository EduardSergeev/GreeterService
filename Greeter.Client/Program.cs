using Greeter.Client.Configuration;
using Greeter.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using static Greeter.Common.Title;
using static System.Console;


using var host = Host.CreateDefaultBuilder(args).Build();
var config = host.Services
    .GetRequiredService<IConfiguration>()
    .GetRequiredSection("GreeterService")
    .Get<GrpcConfiguration>();


var client = new Greeter.Common.Grpc.GreeterServiceGrpcClient(config, false);

WriteLine(client.SayHello("World"));
WriteLine(await client.SayHelloAsync("Async"));


WriteLine();


var clientEx = new Greeter.Common.Grpc.GreeterExtendedServiceGrpcClient(config, false);

var person = new Person
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

var people = person.OtherNames
    .Select(otherName => person with { Name = otherName })
    .Prepend(person);

void WriteGreeting(Greeting greeting)
{
    WriteLine(greeting.Subject);
    foreach(var line in greeting.Lines)
    {
        WriteLine(line);
    }
}


WriteGreeting(clientEx.SayGreeting(person));
WriteGreeting(await clientEx.SayGreetingAsync(person));

foreach(var greeting in clientEx.SayGreetings(people))
{
    WriteGreeting(greeting);
}
await foreach(var greeting in clientEx.SayGreetingsAsync(people))
{
    WriteGreeting(greeting);
}

foreach(var line in clientEx.StreamGreeting(person))
{
    WriteLine(line);
}
await foreach(var line in clientEx.StreamGreetingAsync(person))
{
    WriteLine(line);
}

foreach(var line in clientEx.StreamGreetings(people, new[] { "---" }))
{
    WriteLine(line);
}
await foreach(var line in clientEx.StreamGreetingsAsync(people, new[] { "---", "---", "---" }))
{
    WriteLine(line);
}

foreach(var line in clientEx.StreamGreetingsEx(people.Select((p, i) => (p, new[] { $"-{i}-" }))))
{
    WriteLine(line);
}
await foreach(var line in clientEx.StreamGreetingsExAsync(people.Select(p => (p, new[] { "---", $"{DateTime.Now.Millisecond}", "---" }))))
{
    await Task.Delay(TimeSpan.FromMilliseconds(1));
    WriteLine(line);
}
