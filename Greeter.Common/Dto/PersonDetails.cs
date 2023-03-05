namespace Greeter.Common;

public readonly record struct PersonDetails(
    DateTime DateOfBirth,
    double Height,
    decimal Length,
    Address[] Addresses
);
