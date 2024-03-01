namespace Algorithms.SlidingWindow;

public class Task1
{
    public static double FindMaxAverage(int[] nums, int k)
    {
        if (k == 1)
        {
            return nums.Max();
        }
        var maxAvg = (double) nums[..k].Sum();
        var j = 0;
        var bufAvg = maxAvg;
        for (var i = k; i < nums.Length; i++, j++)
        {
            bufAvg = bufAvg - nums[j] + nums[i];
            if (bufAvg > maxAvg)
            {
                maxAvg = bufAvg;
            }
        }

        return maxAvg / k;
    }
}