namespace Greeter.Common;

public readonly record struct StringArray
(
    string[] Items
);

public readonly record struct NullableStringArray
(
    string?[] Items
);
