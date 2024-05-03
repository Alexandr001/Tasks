using Algorithms.PrefixSum;

namespace Tests;

public class PrefixSumTest
{
    [Theory]
    [InlineData(new[]{-5,1,5,0,-7}, 1)]
    [InlineData(new[]{-4,-3,-2,-1,4,3,2}, 0)]
    public void Test1(int[] nums, int result)
    {
        var s = Task1.LargestAltitude(nums);
        Assert.Equal(s, result);
    }
    [Theory]
    [InlineData(new[]{1,7,3,6,5,6}, 3)]
    [InlineData(new[]{1,2,3}, -1)]
    [InlineData(new[]{2,1,-1}, 0)]
    public void Test2(int[] nums, int result)
    {
        var s = Task2.PivotIndex(nums);
        Assert.Equal(s, result);
    }
}