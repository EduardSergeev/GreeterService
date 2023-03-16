using Greeter.Common;

namespace Greeter.Services;

public class Greeter : IGreeterService
{
    public string SayHello(string name)
    {
        return "Hello " + name;
    }
}
