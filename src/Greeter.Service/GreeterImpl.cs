using Greeter.Common;
using static System.Reflection.Assembly;

namespace Greeter.Service;

public class GreeterImpl : IGreeterService, IGreeterExtendedService
{
    private Version? Version { get; }
    private ILogger<GreeterImpl> Logger { get; }

    public GreeterImpl(ILogger<GreeterImpl> logger)
    {
        Version = GetExecutingAssembly().GetName().Version;
        Logger = logger;
        Logger.LogInformation($"{nameof(GreeterImpl)}: version '{Version}'");
    }

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

        var (dob, height, length, _) = person.Details;
        var detailLines = new[]
        {
            $"Your details are:",
            $"DOB: {dob:dd MMMM yyyy}",
            $"Height: {(int)height}'{height%1*10:0}\"",
            $"Length: {length}\"",
            "",
        };

        var addressLines = person.Details.Addresses
            .Select(address => address switch
            {
                var (street, city, state, postcode, country) =>
                    street.Concat(new[]
                    {
                        city,
                        state,
                        postcode?.ToString(),
                        country
                    })
            })
            .Aggregate((l, r) => l.Append("").Concat(r))
            .OfType<string>()
            .Prepend("You live at:");

        var footer = new[]
        {
            $"",
            $"Sincerely yours,",
            $"{nameof(GreeterImpl)}-{Version}",
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
                .Concat(footer)
            }
        };
    }
}
