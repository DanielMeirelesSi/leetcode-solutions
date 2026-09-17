using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Positivos e negativos", solution.MaxSubArray(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }), 6);
        RunTest("Um único valor negativo", solution.MaxSubArray(new[] { -8 }), -8);
        RunTest("Soma crescente com valores mistos", solution.MaxSubArray(new[] { 5, 4, -1, 7, 8 }), 23);
    }

    private static void RunTest(string name, int actual, int expected)
    {
        Console.WriteLine($"{name}: {(actual == expected ? "PASS" : "FAIL")}");
    }
}
