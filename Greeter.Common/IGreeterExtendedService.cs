namespace Greeter.Common;

public interface IGreeterExtendedService
{
    Greeting SayGreeting(Person person);
    IEnumerable<Greeting> SayGreetings(IEnumerable<Person> people);
    IEnumerable<string> StreamGreeting(Person person);
    IEnumerable<string> StreamGreetings(IEnumerable<Person> people, string[] delimiter);
    IEnumerable<string> StreamGreetingsEx(IEnumerable<(Person Person, string[] Footer)> people);
}
