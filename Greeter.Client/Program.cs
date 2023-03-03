using Greeter.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using static System.Console;

using var host = Host.CreateDefaultBuilder(args).Build();
var config = host.Services
    .GetRequiredService<IConfiguration>()
    .GetRequiredSection("GreeterService")
    .Get<GrpcConfiguration>();


var client = new Greeter.Common.Grpc.GreeterServiceGrpcClient(config, false);

WriteLine(client.SayHello("World"));
WriteLine(await client.SayHelloAsync("Async"));

var clientEx = new Greeter.Common.Grpc.GreeterExtendedServiceGrpcClient(config, false);

var person = new Person
{
    Title = Greeter.Common.Title.Mr,
    FirstName = "Agent",
    LastName = "Smith",
    Addresses = new[]
    {
        new Address
        {
            Street = "221B Baker Street",
            City = "London",
            Postcode = 90210
        }
    }
};

await foreach(var greeting in clientEx.SayGreetingsAsync(person))
{
    WriteLine(greeting.Subject);
    foreach(var line in greeting.Lines)
    {
        WriteLine(line);
    }
}
