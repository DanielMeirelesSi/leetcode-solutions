public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 0)
        {
            return 0;
        }

        if (n <= 2)
        {
            return n;
        }

        int previous = 1;
        int current = 2;

        for (int step = 3; step <= n; step++)
        {
            int next = previous + current;
            previous = current;
            current = next;
        }

        return current;
    }
}
