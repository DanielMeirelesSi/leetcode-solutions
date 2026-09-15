using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Um degrau", solution.ClimbStairs(1), 1);
        RunTest("Dois degraus", solution.ClimbStairs(2), 2);
        RunTest("Cinco degraus", solution.ClimbStairs(5), 8);
    }

    private static void RunTest(string name, int actual, int expected)
    {
        Console.WriteLine($"{name}: {(actual == expected ? "PASS" : "FAIL")}");
    }
}
