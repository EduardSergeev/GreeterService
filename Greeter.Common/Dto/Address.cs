namespace Greeter.Common;

public readonly record struct Address(
    string[] Street,
    string City,
    string State,
    int Postcode
);
