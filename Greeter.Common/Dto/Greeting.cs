namespace Greeter.Common;

public readonly record struct Greeting(
    string Subject,
    IEnumerable<string> Lines
);
