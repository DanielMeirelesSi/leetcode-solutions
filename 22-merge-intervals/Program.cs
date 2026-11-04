using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Exemplo oficial", solution.Merge(new[] { new[] { 1, 3 }, new[] { 2, 6 }, new[] { 8, 10 }, new[] { 15, 18 } }), new[] { "1,6", "8,10", "15,18" });
        RunTest("Extremos em contato", solution.Merge(new[] { new[] { 1, 4 }, new[] { 4, 5 } }), new[] { "1,5" });
        RunTest("Fora de ordem", solution.Merge(new[] { new[] { 4, 7 }, new[] { 1, 4 } }), new[] { "1,7" });
        RunTest("Intervalo contido", solution.Merge(new[] { new[] { 1, 10 }, new[] { 2, 3 }, new[] { 4, 8 } }), new[] { "1,10" });
        RunTest("Intervalos duplicados", solution.Merge(new[] { new[] { 1, 2 }, new[] { 1, 2 } }), new[] { "1,2" });
        RunTest("Pontos isolados", solution.Merge(new[] { new[] { 3, 3 }, new[] { 0, 0 } }), new[] { "0,0", "3,3" });
        RunTest("Mesmo início", solution.Merge(new[] { new[] { 1, 2 }, new[] { 1, 5 }, new[] { 4, 6 } }), new[] { "1,6" });
        RunTest("Entrada vazia", solution.Merge(new int[0][]), new string[0]);
    }

    private static void RunTest(string name, int[][] actual, string[] expected)
    {
        bool passed = actual.Length == expected.Length;
        for (int i = 0; passed && i < expected.Length; i++)
        {
            passed = string.Join(",", actual[i]) == expected[i];
        }
        Console.WriteLine($"{name}: {(passed ? "PASS" : "FAIL")}");
        if (!passed)
        {
            Environment.ExitCode = 1;
        }
    }
}
