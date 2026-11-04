using System;

public class Solution
{
    public int Trap(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int leftMaximum = 0;
        int rightMaximum = 0;
        int water = 0;

        while (left < right)
        {
            if (height[left] <= height[right])
            {
                leftMaximum = Math.Max(leftMaximum, height[left]);
                water += leftMaximum - height[left];
                left++;
            }
            else
            {
                rightMaximum = Math.Max(rightMaximum, height[right]);
                water += rightMaximum - height[right];
                right--;
            }
        }

        return water;
    }
}
