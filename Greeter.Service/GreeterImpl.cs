using Greeter.Common;

namespace Greeter.Service;

public class GreeterImpl : IGreeterService, IGreeterExtendedService
{
    public string SayHello(string name)
    {
        return "Hello " + name;
    }

    public IEnumerable<Greeting> SayGreetings(Person person)
    {
        var addressLines = person.Addresses?.FirstOrDefault() switch
        {
            null => Enumerable.Empty<string>(),
            Address address => new[]
            {
                "Living at:",
                address.Street,
                address.City,
                address.State,
                $"{address.Postcode}"
            }.Where(l => l is not null)
        };
        return new[]
        {
            new Greeting
            {
                Subject = $"Hello {person.Title} {person.LastName}",
                Lines = new[]
                {
                    $"Wellcome dear {person.FirstName} {person.LastName}!",
                }
                .Concat(addressLines)
            }
        };
    }
}
