namespace Algorithms.TwoPointers;
/// <summary>
/// 392. Is Subsequence
/// </summary>
public class Task2
{
    public bool IsSubsequence(string s, string t)
    {
        var i = 0;
        foreach (var c in t)
        {
            if (i == s.Length)
            {
                return true;
            }
            if (c == s[i])
            {
                i++;
            }
        }

        return i == s.Length;
    }
}