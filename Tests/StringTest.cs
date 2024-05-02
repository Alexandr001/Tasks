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
    [Theory]
    [InlineData("abcabc", "abc", "abc")]
    [InlineData("ababab", "abab", "ab")]
    [InlineData("leet", "code", "")]
    public void Test2(string word1, string word2, string result)
    {
        var s = Task2.GcdOfStrings(word1, word2);
        Assert.Equal(result, s);
    }
    [Theory]
    [InlineData("hello", "holle")]
    [InlineData("leetcode", "leotcede")]
    [InlineData("Aa", "aA")]
    public void Test5(string s, string result)
    {
        var res = Task5.ReverseVowels(s);
        Assert.Equal(result, res);
    }
}