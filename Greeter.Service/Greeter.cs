using Greater.Common;

namespace Greater.Service;

public class Greeter : IGreeterService
{
    public string SayHello(string name)
    {
        return "Hello " + name;
    }
}
