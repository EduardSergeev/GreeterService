namespace Greeter.Common;

public readonly record struct Name(
    Title Title,
    string FirstName,
    string LastName,
    string? MiddleName = null
);
