using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Valor na primeira posição", solution.Search(new[] { 5 }, 5), 0);
        RunTest("Valor na última posição", solution.Search(new[] { 1, 3, 5, 7, 9 }, 9), 4);
        RunTest("Valor inexistente", solution.Search(new[] { 1, 3, 5, 7, 9 }, 2), -1);
    }

    private static void RunTest(string name, int actual, int expected)
    {
        Console.WriteLine($"{name}: {(actual == expected ? "PASS" : "FAIL")}");
    }
}
