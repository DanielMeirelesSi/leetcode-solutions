using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        RunTest("Exemplo oficial ímpar", solution.FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2 }), 2.0);
        RunTest("Exemplo oficial par", solution.FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4 }), 2.5);
        RunTest("Primeiro vazio", solution.FindMedianSortedArrays(new int[0], new[] { 1 }), 1.0);
        RunTest("Segundo vazio", solution.FindMedianSortedArrays(new[] { -2, -1 }, new int[0]), -1.5);
        RunTest("Valores iguais", solution.FindMedianSortedArrays(new[] { 0, 0 }, new[] { 0, 0 }), 0.0);
        RunTest("Limites opostos", solution.FindMedianSortedArrays(new[] { -1000000 }, new[] { 1000000 }), 0.0);
        RunTest("Valores máximos", solution.FindMedianSortedArrays(new[] { 1000000 }, new[] { 1000000 }), 1000000.0);
        RunTest("Partição na extremidade", solution.FindMedianSortedArrays(new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }), 4.5);
        int[] first = new int[1000];
        int[] second = new int[1000];
        for (int i = 0; i < 1000; i++)
        {
            first[i] = i * 2;
            second[i] = i * 2 + 1;
        }
        RunTest("Dois arrays máximos", solution.FindMedianSortedArrays(first, second), 999.5);
        RunTest("Tamanhos desbalanceados", solution.FindMedianSortedArrays(new[] { -1000000 }, second), 999.0);

        Random random = new Random(4);
        for (int test = 0; test < 500; test++)
        {
            int[] a = new int[random.Next(0, 21)];
            int[] b = new int[random.Next(a.Length == 0 ? 1 : 0, 21)];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(-10, 11);
            }
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = random.Next(-10, 11);
            }
            Array.Sort(a);
            Array.Sort(b);
            int[] combined = new int[a.Length + b.Length];
            a.CopyTo(combined, 0);
            b.CopyTo(combined, a.Length);
            Array.Sort(combined);
            int middle = combined.Length / 2;
            double expected = combined.Length % 2 == 1 ? combined[middle] : ((double)combined[middle - 1] + combined[middle]) / 2;
            RunTest($"Referência por ordenação {test}", solution.FindMedianSortedArrays(a, b), expected);
            RunTest($"Simetria {test}", solution.FindMedianSortedArrays(b, a), expected);
        }
    }

    private static void RunTest(string name, double actual, double expected)
    {
        bool passed = Math.Abs(actual - expected) < 0.000001;
        Console.WriteLine($"{name}: {(passed ? "PASS" : "FAIL")}");
        if (!passed)
        {
            Console.WriteLine($"  Esperado: {expected}; obtido: {actual}");
            Environment.ExitCode = 1;
        }
    }
}
