using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        int[] sorted = (int[])candidates.Clone();
        Array.Sort(sorted);
        List<IList<int>> combinations = new List<IList<int>>();
        Search(sorted, target, 0, new List<int>(), combinations);
        return combinations;
    }

    private void Search(int[] candidates, int remaining, int start, List<int> path, List<IList<int>> combinations)
    {
        if (remaining == 0)
        {
            combinations.Add(new List<int>(path));
            return;
        }

        for (int i = start; i < candidates.Length; i++)
        {
            if (candidates[i] > remaining)
            {
                break;
            }

            path.Add(candidates[i]);
            Search(candidates, remaining - candidates[i], i, path, combinations);
            path.RemoveAt(path.Count - 1);
        }
    }
}
