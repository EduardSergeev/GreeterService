namespace Greeter.Uncommon;

public interface IGreeterExtendedService
{
    IEnumerable<Greeting> SayGreetings(Person person);
}
