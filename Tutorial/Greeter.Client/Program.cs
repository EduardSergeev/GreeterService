using Greeter.Client;
using Greeter.Common;
using static Greeter.Common.Title;
using static System.Console;

var client = new Greeter.Common.Grpc.GreeterServiceGrpcClient(new GrpcConfiguration(), false);

var person = new Person
{
    Name = new()
    {
        Title = Mr,
        FirstName = "Eric",
        LastName = "Cartman",
    },
    DateOfBirth = new(DateTime.Now.Year - 10, 7, 1),
    Addresses =
    [
        new Address
        {
            Street = [ "28201 E. Bonanza St." ],
            City = "South Park",
            State = "Colorado",
            Country = "USA",
            Postcode = 80440
        },
    ]
};

WriteGreeting(client.SayGreeting(person));
WriteGreeting(await client.SayGreetingAsync(person));


void WriteGreeting(Greeting greeting)
{
    WriteLine(greeting.Subject);
    foreach(var line in greeting.Lines)
    {
        WriteLine(line);
    }
}
