using System;

public class Solution
{
    public int MaxCoins(int[] nums)
    {
        int[] values = new int[nums.Length + 2];
        values[0] = 1;
        values[values.Length - 1] = 1;
        Array.Copy(nums, 0, values, 1, nums.Length);
        int[,] best = new int[values.Length, values.Length];

        for (int width = 2; width < values.Length; width++)
        {
            for (int left = 0; left + width < values.Length; left++)
            {
                int right = left + width;
                for (int last = left + 1; last < right; last++)
                {
                    int coins = best[left, last] + best[last, right]
                        + values[left] * values[last] * values[right];
                    best[left, right] = Math.Max(best[left, right], coins);
                }
            }
        }

        return best[0, values.Length - 1];
    }
}
