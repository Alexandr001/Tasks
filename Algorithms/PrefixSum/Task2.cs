namespace Algorithms.PrefixSum;
/// <summary>
/// 724. Find Pivot Index
/// </summary>
public class Task2
{
    public static int PivotIndex(int[] nums)
    {
        if (nums.Length <= 1)
        {
            return 0;
        }
        var numsLength = nums.Length / 2;
        var leftSum = nums[..numsLength].Sum();
        var rightSum = nums[(numsLength + 1)..].Sum();
        if (leftSum == rightSum)
        {
            return numsLength;
        }
        for (var i = numsLength; i > 0; i--)
        {
            if (leftSum - nums[i - 1] == rightSum + nums[i])
            {
                return i;
            }
        }

        for (int i = numsLength + 1; i < nums.Length; i++)
        {
            if (leftSum + nums[i + 1] == rightSum - nums[i])
            {
                return i;
            }
        }
        return -1;
    }
}