namespace Algorithms.TwoPointers;

public class Task1
{
    public static int[] MoveZeroes(int[] nums)
    {
        var j = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                j++;
            }
        }

        return nums;
    }
}