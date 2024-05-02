namespace Algorithms.String;

/// <summary>
/// 1768. Merge Strings Alternately
/// </summary>
public class Task1
{
    public static string MergeAlternately(string word1, string word2)
    {
        var s = "";
        for (var i = 0; i < word1.Length || i < word2.Length; i++)
        {
            if (i < word1.Length)
            {
                s += word1[i];
            }
            if (i < word2.Length)
            {
                s += word2[i];
            }
        }
        return s;
    }
}