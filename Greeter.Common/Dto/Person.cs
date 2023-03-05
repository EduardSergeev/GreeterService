namespace Greeter.Common;

public readonly record struct Person(
    Name Name,
    List<Name> OtherNames,
    string[] Aliases,
    PersonDetails Details
);
