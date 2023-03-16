using Greeter.Common;
using static System.Reflection.Assembly;

namespace Greeter.Services;

public class GreeterExtended : IGreeterExtendedService
{
    private Version? Version { get; }
    private ILogger<GreeterExtended> Logger { get; }

    public GreeterExtended(ILogger<GreeterExtended> logger)
    {
        Version = GetExecutingAssembly().GetName().Version;
        Logger = logger;
        Logger.LogInformation($"{nameof(GreeterExtended)}: version '{Version}'");
    }


    public Greeting SayGreeting(Person person)
    {
        return GenerateGreeting(person);
    }

    public IEnumerable<Greeting> SayGreetings(IAsyncEnumerable<Person> people)
    {
        return people.ToBlockingEnumerable().Select(GenerateGreeting);
    }

    #pragma warning disable CS1998
    public async IAsyncEnumerable<string> StreamGreetingAsync(Person person)
    {
        var (subject, lines) = GenerateGreeting(person);
        yield return subject;
        foreach(var line in lines)
        {
            yield return line;
        }
    }

    public async IAsyncEnumerable<Greeting> StreamGreetingsAsync(IAsyncEnumerable<Person> people)
    {
        await foreach(var person in people)
        {
            yield return GenerateGreeting(person);
        }
    }


    private Greeting GenerateGreeting(Person person)
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
            $"{nameof(GreeterExtended)}-{Version}",
        };

        return new Greeting
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
        };
    }
}
