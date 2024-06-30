namespace Greeter.Common;

public readonly record struct Person
(
    Name Name,
    DateTime? DateOfBirth,
    Address[] Addresses
);
