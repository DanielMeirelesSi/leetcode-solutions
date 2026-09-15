public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int nextNonZero = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[nextNonZero] = nums[i];
                nextNonZero++;
            }
        }

        while (nextNonZero < nums.Length)
        {
            nums[nextNonZero] = 0;
            nextNonZero++;
        }
    }
}
