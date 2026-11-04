using System;
using System.Collections.Generic;

public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length == 0)
        {
            return new int[0][];
        }

        Array.Sort(intervals, (first, second) => first[0].CompareTo(second[0]));
        List<int[]> merged = new List<int[]>();
        int start = intervals[0][0];
        int end = intervals[0][1];

        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] <= end)
            {
                end = Math.Max(end, intervals[i][1]);
            }
            else
            {
                merged.Add(new[] { start, end });
                start = intervals[i][0];
                end = intervals[i][1];
            }
        }

        merged.Add(new[] { start, end });
        return merged.ToArray();
    }
}
