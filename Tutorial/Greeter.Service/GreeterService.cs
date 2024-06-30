using Greeter.Common;
namespace Greeter.Service;

public class GreeterService : IGreeterService
{
    public Greeting SayGreeting(Person person)
    {
        var name = person.Name;

        var detailLines = new[]
        {
            $"Your details are:",
            $"DOB: {person.DateOfBirth:dd MMMM yyyy}",
            "",
        };

        return new Greeting
        {
            Subject = $"Hello {name.Title} {name.LastName}!",
            Lines = new[]
            {
                "",
                $"Dear {name.FirstName} {name.LastName},",
                "",
            }
            .Concat(detailLines)
        };
    }
}
