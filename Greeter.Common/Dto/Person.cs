namespace Greeter.Common;

public readonly record struct Person(
    Title Title,
    string FirstName,
    string LastName,
    Address[] Addresses
);
