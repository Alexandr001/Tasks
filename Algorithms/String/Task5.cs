namespace Algorithms.String;

/// <summary>
/// 345. Reverse Vowels of a String
/// </summary>
public class Task5
{
    public static string ReverseVowels(string s)
    {
        var array = s.ToCharArray();
        var chars = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        for (int i = 0, j = array.Length - 1; j >= i; i++)
        {
            if (chars.Contains(array[i]))
            {
                for (; j > i; j--)
                {
                    if (chars.Contains(array[j]))
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                        j--;
                        break;
                    }
                }
            }
        }

        return new string(array);
    }
}