using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Exemplo oficial", solution.FindKthLargest(new[] { 3, 2, 1, 5, 6, 4 }, 2), 5);
        RunTest("Duplicados contam", solution.FindKthLargest(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4), 4);
        RunTest("Maior elemento", solution.FindKthLargest(new[] { -3, -1, -2 }, 1), -1);
        RunTest("Menor elemento", solution.FindKthLargest(new[] { -3, -1, -2 }, 3), -3);
        RunTest("Um elemento", solution.FindKthLargest(new[] { 7 }, 1), 7);
        RunTest("Todos iguais", solution.FindKthLargest(new[] { 2, 2, 2 }, 2), 2);
        int[] values = new int[100000];
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = i % 20001 - 10000;
        }
        RunTest("Array no tamanho máximo", solution.FindKthLargest(values, 1), 10000);
    }

    private static void RunTest<T>(string name, T actual, T expected)
    {
        bool passed = Equals(actual, expected);
        Console.WriteLine($"{name}: {(passed ? "PASS" : "FAIL")}");
        if (!passed)
        {
            Environment.ExitCode = 1;
        }
    }
}
