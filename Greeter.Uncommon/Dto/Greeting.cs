namespace Greeter.Uncommon;

public readonly record struct Greeting
(
    string Subject,
    IEnumerable<string> Lines
);
