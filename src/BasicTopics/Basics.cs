namespace BasicTopics;

public record Person(string Name, int Age, int Weight, Func<int, int, bool> RiskScoreFunction);

public static class Records
{
}