using Algorithms.TwoPointers;

namespace Tests;

public class TwoPointersTest
{
    [Theory]
    [InlineData(new[]{0,1,0,3,12}, new[]{1,3,12,0,0})]
    [InlineData(new[]{0}, new[]{0})]
    public void Test1(int[] nums, int[] result)
    {
        var s = Task1.MoveZeroes(nums);
        Assert.Equal(s, result);
    }
}