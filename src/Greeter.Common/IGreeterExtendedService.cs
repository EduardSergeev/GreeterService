namespace Greeter.Common;

public interface IGreeterExtendedService
{
    IEnumerable<Greeting> SayGreetings(Person person);
}
