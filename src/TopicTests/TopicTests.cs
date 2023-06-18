namespace TopicTests;

public class BasicTests
{
    [Fact]
    public void Record()
    {
    }

    [Fact]
    public void OptionTypeSomeWorks()
    {
        var test = Option<string>.Some("test");
        test = Option<string>.None;
        test = Option<string>.Some("One");
        Assert.Equal("One", Option<string>.GetValue(test));
    }

    [Fact]
    public void OptionTypeNoneWorks()
    {
        var test = Option<int>.Some(23);
        test = Option<int>.None;
        Assert.Equal(Option<int>.None, test);
    }

    [Fact]
    public void OptionTypeDefaultWorks()
    {
        var test = Option<int>.None;
        var result = Option<int>.GetValueOrDefault(test, 23);
        Assert.Equal(23, result); 
    }

    [Fact]
    public void PatternMatchOptionSome()
    {
        var test = Option<int>.Some(120);
        var result =
            test switch
            {
                {IsSome: true} => "Full",
                {IsNone: true} => "Empty",
                _              => "",
            };

        Assert.Equal("Full", result);
    }

    [Fact]
    public void PatternMatchOptionNone()
    {
        var test = Option<int>.None;
        var result =
            test switch
            {
                {IsSome: true} => "Full",
                {IsNone: true} => "Empty",
                _              => "Broken",
            };

        Assert.Equal("Empty", result);
    }
}