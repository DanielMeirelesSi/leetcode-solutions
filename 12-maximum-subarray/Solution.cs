public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int currentSum = nums[0];
        int maximumSum = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            int sumWithCurrent = currentSum + nums[i];
            currentSum = nums[i] > sumWithCurrent ? nums[i] : sumWithCurrent;

            if (currentSum > maximumSum)
            {
                maximumSum = currentSum;
            }
        }

        return maximumSum;
    }
}
