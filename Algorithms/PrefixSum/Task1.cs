namespace Algorithms.PrefixSum;

public class Task1
{
    public static int LargestAltitude(int[] gain)
    {
        var max = 0;
        var buf = max;
        foreach (var i in gain)
        {
            buf += i;
            if (buf > max)
            {
                max = buf;
            }
        }

        return max;
    }
}