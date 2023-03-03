namespace Greeter.Common;

public readonly record struct Greeting(
    string Subject,
    string[] Lines
);
