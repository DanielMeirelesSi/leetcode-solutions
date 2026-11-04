using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Exemplo oficial", solution.LargestRectangleArea(new[] { 2, 1, 5, 6, 2, 3 }), 10);
        RunTest("Duas barras", solution.LargestRectangleArea(new[] { 2, 4 }), 4);
        RunTest("Crescente", solution.LargestRectangleArea(new[] { 1, 2, 3, 4, 5 }), 9);
        RunTest("Decrescente", solution.LargestRectangleArea(new[] { 5, 4, 3, 2, 1 }), 9);
        RunTest("Alturas iguais", solution.LargestRectangleArea(new[] { 3, 3, 3 }), 9);
        RunTest("Zeros separam retângulos", solution.LargestRectangleArea(new[] { 2, 0, 2 }), 2);
        RunTest("Uma barra", solution.LargestRectangleArea(new[] { 7 }), 7);
        RunTest("Tudo zero", solution.LargestRectangleArea(new[] { 0, 0 }), 0);
        RunTest("Entrada vazia", solution.LargestRectangleArea(new int[0]), 0);
        int[] maximum = new int[100000];
        Array.Fill(maximum, 10000);
        RunTest("Área máxima", solution.LargestRectangleArea(maximum), 1000000000);
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
