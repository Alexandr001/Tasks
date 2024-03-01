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
}