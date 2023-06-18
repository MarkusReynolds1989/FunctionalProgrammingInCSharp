namespace BasicTopics;

public static class Functions
{
    // In CSharp functions are first class citizens.
    public static Func<int, int, int> X(int y, int z)
    {
        var q = y + z;

        // You can define local functions and then return them.
        int bar(int foo, int another) => foo + another;
        // Create a local variable to point to the function or return it as "new".
        var funcPointer = bar;
        // Be careful to avoid creating anonymous functions as it has a performance hit.
        return funcPointer;
    }

    public static string ReadConfig(Func<string, string> configReader, string config)
    {
        Console.WriteLine("The reason you would have this is so you can have data that is shared.");
        return configReader(config);
    }

    // Logic here.
    public static string JsonReader(string config) => "";
    public static string JsonConfigReader() => ReadConfig(JsonReader, "");
}

public static class PatternMatching
{
}

public class Option<T>
{
    private readonly T _value;

    public bool IsSome { get; }
    public bool IsNone => !IsSome;

    private Option(T value)
    {
        _value = value;
        IsSome = true;
    }

    private Option()
    {
        IsSome = false;
    }

    public static T GetValueOrDefault(Option<T> value, T defaultValue) =>
        value switch
        {
            {IsSome: true} => value._value,
            {IsNone: true} => defaultValue,
            _              => defaultValue
        };

    public static T GetValue(Option<T> value) => value._value;

    public static Option<T> Some(T value) => new(value);
    public static Option<T> None { get; } = new();
}

public static class OptionExtensions
{
}

public record Person(string Name, int Age, int Weight, Func<int, int, bool> RiskScoreFunction);

public static class Records
{
}