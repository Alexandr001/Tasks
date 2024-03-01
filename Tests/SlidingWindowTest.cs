using Algorithms.SlidingWindow;

namespace Tests;

public class SlidingWindowTest
{
    [Theory]
    [InlineData(new[]{1,12,-5,-6,50,3}, 4, 12.75000d)]
    [InlineData(new[]{5}, 1, 5.00000d)]
    [InlineData(new[]{-1}, 1, -1.00000d)]
    [InlineData(new[]{4,2,1,3,3}, 2, 3.00000d)]
    public void Test1(int[] nums, int k, double result)
    {
        var s = Task1.FindMaxAverage(nums, k);
        Assert.Equal(s, result);
    }
}