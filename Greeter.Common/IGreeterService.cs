namespace Greeter.Common;

public interface IGreeterService
{
    string SayHello(string name);
    IEnumerable<Greeting> SayGreetings(Person person);
}
