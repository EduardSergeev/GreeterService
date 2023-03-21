using Greeter.Common;

namespace Greeter.Services;

public class GreeterExtended : IGreeterExtendedService
{
    private Version Version { get; }

    public GreeterExtended(Version version)
    {
        Version = version;
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
            $"",
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


    public Greeting SayGreeting(Person person) =>
        GenerateGreeting(person);

    public IEnumerable<Greeting> SayGreetings(IEnumerable<Person> people) =>
        people.Select(GenerateGreeting);

    public IEnumerable<string> StreamGreeting(Person person) =>
        GenerateGreeting(person) switch
        {
            var (subject, lines) => lines.Prepend(subject)
        };

    public IEnumerable<string> StreamGreetings(IEnumerable<Person> people, string[] delimiter) =>
        people
            .Select(GenerateGreeting)
            .Select(greeting => greeting.Lines.Prepend(greeting.Subject))
            .Aggregate((l, r) => l.Concat(delimiter).Concat(r));

    public IEnumerable<string> StreamGreetingsEx(IEnumerable<(Person Person, string? Footer)> people) =>
        from item in people
        let greeting = GenerateGreeting(item.Person)
        let lines = greeting.Lines.Prepend(greeting.Subject)
        from line in item.Footer is null ? lines : lines.Append(item.Footer)
        select line;

    public IEnumerable<string> StreamGreetingsEx(IEnumerable<(Person Person, string[] Footer)> people) =>
        from item in people
        let greeting = GenerateGreeting(item.Person)
        from line in greeting.Lines.Prepend(greeting.Subject).Concat(item.Footer)
        select line;
}
