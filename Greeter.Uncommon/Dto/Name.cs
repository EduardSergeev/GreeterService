namespace Greeter.Uncommon;

public readonly record struct Name
(
    Title Title,
    string FirstName,
    string LastName,
    string? MiddleName = null
);
