using System.Collections.Generic;

public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        PriorityQueue<int, int> largest = new PriorityQueue<int, int>();

        foreach (int value in nums)
        {
            largest.Enqueue(value, value);
            if (largest.Count > k)
            {
                largest.Dequeue();
            }
        }

        return largest.Peek();
    }
}
