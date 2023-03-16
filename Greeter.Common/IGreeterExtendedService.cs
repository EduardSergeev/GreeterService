namespace Greeter.Common;

public interface IGreeterExtendedService
{
    Greeting SayGreeting(Person person);
    IEnumerable<Greeting> SayGreetings(IAsyncEnumerable<Person> people);
    IAsyncEnumerable<string> StreamGreetingAsync(Person person);
    IAsyncEnumerable<Greeting> StreamGreetingsAsync(IAsyncEnumerable<Person> people);
}
