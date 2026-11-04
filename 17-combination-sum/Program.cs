using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Exemplo oficial", solution.CombinationSum(new[] { 2, 3, 6, 7 }, 7), new[] { "2,2,3", "7" });
        RunTest("Várias combinações", solution.CombinationSum(new[] { 2, 3, 5 }, 8), new[] { "2,2,2,2", "2,3,3", "3,5" });
        RunTest("Impossível", solution.CombinationSum(new[] { 2 }, 1), new string[0]);
        RunTest("Reutilização", solution.CombinationSum(new[] { 2 }, 8), new[] { "2,2,2,2" });
        RunTest("Candidatos fora de ordem", solution.CombinationSum(new[] { 7, 3, 2, 6 }, 7), new[] { "2,2,3", "7" });
        RunTest("Nenhuma permutação duplicada", solution.CombinationSum(new[] { 2, 3 }, 12), new[] { "2,2,2,2,2,2", "2,2,2,3,3", "3,3,3,3" });
        RunTest("Alvo máximo", solution.CombinationSum(new[] { 40 }, 40), new[] { "40" });
        RunTest("Candidatos vazios", solution.CombinationSum(new int[0], 7), new string[0]);
    }

    private static void RunTest(string name, IList<IList<int>> actual, string[] expected)
    {
        List<string> combinations = new List<string>();
        foreach (IList<int> combination in actual)
        {
            List<int> values = new List<int>(combination);
            values.Sort();
            combinations.Add(string.Join(",", values));
        }
        combinations.Sort(StringComparer.Ordinal);
        Array.Sort(expected, StringComparer.Ordinal);
        bool passed = combinations.Count == expected.Length;
        for (int i = 0; passed && i < expected.Length; i++)
        {
            passed = combinations[i] == expected[i];
        }
        Console.WriteLine($"{name}: {(passed ? "PASS" : "FAIL")}");
        if (!passed)
        {
            Environment.ExitCode = 1;
        }
    }
}
