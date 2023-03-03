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
        return new[]
        {
            new Greeting
            {
                Subject = $"Hello {person.Title} {person.LastName}",
                Lines = new[]
                {
                    $"Wellcome dear {person.FirstName} {person.LastName}!",
                },
            }
        };
    }
}
