using Greeter.Common;
using static System.Environment;

namespace Greeter.Service;

public class GreeterImpl : IGreeterService, IGreeterExtendedService
{
    public string SayHello(string name)
    {
        return "Hello " + name;
    }

    public IEnumerable<Greeting> SayGreetings(Person person)
    {
        var name = person.Name;

        var otherNames = person.OtherNames
            .Select(name => name switch
            {
                var (_, first, second, _) =>
                    $"\"{string.Join(' ', new[] { first, second, })}\""
            });

        var (dob, height, length, addresses) = person.Details;
        var detailLines = new[]
        {
            "Your details are:",
            $"DOB: {dob:dd MMMM yyyy}",
            $"Height: {(int)height}'{height%1*10:0}\"",
            $"Length: {length}\"",
            "",
        };

        var addressLines = addresses?.FirstOrDefault() switch
        {
            null => Enumerable.Empty<string>(),
            Address address => new[]
            {
                "You live at:",
                string.Join(NewLine, address.Street),
                address.City,
                address.State,
                address.Postcode?.ToString()
            }.OfType<string>()
        };

        return new[]
        {
            new Greeting
            {
                Subject = $"Hello {name.Title} {name.LastName}!",
                Lines = new[]
                {
                    "",
                    $"Dear {name.FirstName} {name.LastName}{(otherNames.Any() ?
                        $" (aka: {string.Join(" and ", otherNames)})" : "")},",
                    "",
                }
                .Concat(detailLines)
                .Concat(addressLines)
            }
        };
    }
}
