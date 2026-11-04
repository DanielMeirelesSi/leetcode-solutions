public class Solution
{
    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        int[] result = new int[nums.Length - k + 1];
        int[] deque = new int[k];
        int head = 0;
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            while (count > 0 && deque[head] <= i - k)
            {
                head = (head + 1) % k;
                count--;
            }

            while (count > 0 && nums[deque[(head + count - 1) % k]] <= nums[i])
            {
                count--;
            }

            deque[(head + count) % k] = i;
            count++;

            if (i >= k - 1)
            {
                result[i - k + 1] = nums[deque[head]];
            }
        }

        return result;
    }
}
