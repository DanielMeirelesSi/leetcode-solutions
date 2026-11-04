using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        RunTest("Exemplo oficial 1", solution.MaxCoins(new[] { 3, 1, 5, 8 }), 167);
        RunTest("Exemplo oficial 2", solution.MaxCoins(new[] { 1, 5 }), 10);
        RunTest("Um balão zero", solution.MaxCoins(new[] { 0 }), 0);
        RunTest("Um balão máximo", solution.MaxCoins(new[] { 100 }), 100);
        RunTest("Zeros entre valores", solution.MaxCoins(new[] { 3, 0, 5 }), 20);
        RunTest("Valores repetidos", solution.MaxCoins(new[] { 2, 2, 2 }), 14);
        RunTest("Escolha greedy incorreta", solution.MaxCoins(new[] { 9, 1, 9 }), 171);
        int[] maximum = new int[300];
        Array.Fill(maximum, 100);
        RunTest("300 valores máximos", solution.MaxCoins(maximum), 298010100);
        Array.Fill(maximum, 1);
        RunTest("300 valores iguais a um", solution.MaxCoins(maximum), 300);
        Array.Clear(maximum);
        RunTest("300 zeros", solution.MaxCoins(maximum), 0);

        Random random = new Random(312);
        for (int test = 0; test < 200; test++)
        {
            int[] values = new int[random.Next(1, 8)];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(0, 6);
            }
            int[] original = (int[])values.Clone();
            RunTest($"Referência por remoções {test}", solution.MaxCoins(values), Reference(new List<int>(values)));
            RunTest($"Entrada preservada {test}", AreEqual(values, original), true);
        }
    }

    private static int Reference(List<int> remaining)
    {
        int best = 0;
        for (int i = 0; i < remaining.Count; i++)
        {
            int left = i == 0 ? 1 : remaining[i - 1];
            int right = i + 1 == remaining.Count ? 1 : remaining[i + 1];
            int value = remaining[i];
            remaining.RemoveAt(i);
            best = Math.Max(best, left * value * right + Reference(remaining));
            remaining.Insert(i, value);
        }
        return best;
    }

    private static bool AreEqual(int[] first, int[] second)
    {
        for (int i = 0; i < first.Length; i++)
        {
            if (first[i] != second[i])
            {
                return false;
            }
        }
        return true;
    }

    private static void RunTest<T>(string name, T actual, T expected)
    {
        bool passed = Equals(actual, expected);
        Console.WriteLine($"{name}: {(passed ? "PASS" : "FAIL")}");
        if (!passed)
        {
            Console.WriteLine($"  Esperado: {expected}; obtido: {actual}");
            Environment.ExitCode = 1;
        }
    }
}
