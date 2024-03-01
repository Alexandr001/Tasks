using Algorithms.String;

namespace Tests;

public class StringTest
{
    [Theory]
    [InlineData("abc", "pqr", "apbqcr")]
    [InlineData("ab", "pqrs", "apbqrs")]
    [InlineData("abcd", "pq", "apbqcd")]
    public void Test1(string word1, string word2, string result)
    {
        var s = Task1.MergeAlternately(word1, word2);
        Assert.Equal(result, s);
    }
}