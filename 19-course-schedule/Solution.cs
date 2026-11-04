using System.Collections.Generic;

public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        List<int>[] dependents = new List<int>[numCourses];
        int[] incoming = new int[numCourses];
        for (int course = 0; course < numCourses; course++)
        {
            dependents[course] = new List<int>();
        }

        foreach (int[] prerequisite in prerequisites)
        {
            dependents[prerequisite[1]].Add(prerequisite[0]);
            incoming[prerequisite[0]]++;
        }

        Queue<int> available = new Queue<int>();
        for (int course = 0; course < numCourses; course++)
        {
            if (incoming[course] == 0)
            {
                available.Enqueue(course);
            }
        }

        int completed = 0;
        while (available.Count > 0)
        {
            int course = available.Dequeue();
            completed++;

            foreach (int dependent in dependents[course])
            {
                incoming[dependent]--;
                if (incoming[dependent] == 0)
                {
                    available.Enqueue(dependent);
                }
            }
        }

        return completed == numCourses;
    }
}
