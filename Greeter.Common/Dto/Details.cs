namespace Greeter.Common;

public readonly record struct Details
(
    DateTime DateOfBirth,
    double Height,
    decimal Length,
    Address[] Addresses
);
