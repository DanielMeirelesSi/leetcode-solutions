using System;
using System.Collections.Generic;

public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        Stack<int> increasing = new Stack<int>();
        int maximumArea = 0;

        for (int i = 0; i <= heights.Length; i++)
        {
            int currentHeight = i == heights.Length ? 0 : heights[i];

            while (increasing.Count > 0 && heights[increasing.Peek()] >= currentHeight)
            {
                int height = heights[increasing.Pop()];
                int left = increasing.Count == 0 ? -1 : increasing.Peek();
                int width = i - left - 1;
                maximumArea = Math.Max(maximumArea, height * width);
            }

            if (i < heights.Length)
            {
                increasing.Push(i);
            }
        }

        return maximumArea;
    }
}
