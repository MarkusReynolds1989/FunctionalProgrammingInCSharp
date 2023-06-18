namespace GlobalHelpers;

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