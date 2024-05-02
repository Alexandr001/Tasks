namespace Algorithms.String;

/// <summary>
/// 1071. Greatest Common Divisor of Strings
/// </summary>
public class Task2
{
    public static int Gcd(int n1, int n2)
    {
        return n2 == 0 ? n1 : Gcd(n2, n1 % n2);
    }

    public static string GcdOfStrings(string str1, string str2)
    {
        int len1 = str1.Length;
        int len2 = str2.Length;
        if ((str1 + str2).Equals(str2 + str1))
        {
            int index = Gcd(len1, len2);
            return str1[..index];
        }

        return "";
    }
}