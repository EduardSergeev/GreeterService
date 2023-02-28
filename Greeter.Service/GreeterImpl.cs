using Greeter.Common;

namespace Greeter.Service;

public class GreeterImpl : IGreeterService
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
                Text = $"Wellcome dear {person.FirstName} {person.LastName}"
            }
        };
    }
}
