namespace Greeter.Uncommon;

public readonly record struct Person
(
    Name Name,
    List<Name> OtherNames,
    string[] Aliases,
    Details Details
);
