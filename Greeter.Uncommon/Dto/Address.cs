namespace Greeter.Uncommon;

public readonly record struct Address
(
    string[] Street,
    string City,
    string? State,
    int? Postcode,
    string? Country
);
