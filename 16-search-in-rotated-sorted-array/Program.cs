using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Alvo depois da rotação", solution.Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0), 4);
        RunTest("Alvo ausente", solution.Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3), -1);
        RunTest("Metade esquerda", solution.Search(new[] { 4, 5, 6, 7, 0, 1, 2 }, 6), 2);
        RunTest("Sem rotação", solution.Search(new[] { -3, 0, 4, 9 }, 9), 3);
        RunTest("Um elemento presente", solution.Search(new[] { 1 }, 1), 0);
        RunTest("Um elemento ausente", solution.Search(new[] { 1 }, 0), -1);
        RunTest("Dois elementos", solution.Search(new[] { 3, 1 }, 1), 1);
        RunTest("Array vazio", solution.Search(new int[0], 1), -1);
        for (int rotation = 0; rotation < 20; rotation++)
        {
            int[] values = new int[20];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = (i + rotation) % values.Length - 10;
            }
            bool passed = solution.Search(values, 30) == -1;
            for (int i = 0; i < values.Length; i++)
            {
                passed = passed && solution.Search(values, values[i]) == i;
            }
            RunTest($"Todos os alvos na rotação {rotation}", passed, true);
        }
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
