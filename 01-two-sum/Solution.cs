using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> indices = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (indices.TryGetValue(complement, out int complementIndex))
            {
                return new[] { complementIndex, i };
            }

            indices[nums[i]] = i;
        }

        return new int[0];
    }
}
