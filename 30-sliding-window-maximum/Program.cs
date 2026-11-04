using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        RunTest("Exemplo oficial 1", solution.MaxSlidingWindow(new[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3), new[] { 3, 3, 5, 5, 6, 7 });
        RunTest("Exemplo oficial 2", solution.MaxSlidingWindow(new[] { 1 }, 1), new[] { 1 });
        RunTest("Janela unitária", solution.MaxSlidingWindow(new[] { -1, 2, -3 }, 1), new[] { -1, 2, -3 });
        RunTest("Janela cobre tudo", solution.MaxSlidingWindow(new[] { -4, -2, -5 }, 3), new[] { -2 });
        RunTest("Máximos repetidos", solution.MaxSlidingWindow(new[] { 5, 5, 1, 5, 1 }, 2), new[] { 5, 5, 5, 5 });
        RunTest("Expiração do maior", solution.MaxSlidingWindow(new[] { 9, 1, 2, 3 }, 2), new[] { 9, 2, 3 });
        RunTest("Decrescente", solution.MaxSlidingWindow(new[] { 5, 4, 3, 2, 1 }, 3), new[] { 5, 4, 3 });
        RunTest("Crescente", solution.MaxSlidingWindow(new[] { 1, 2, 3, 4, 5 }, 3), new[] { 3, 4, 5 });
        RunTest("Extremos oficiais", solution.MaxSlidingWindow(new[] { -10000, 10000, -10000 }, 2), new[] { 10000, 10000 });
        int[] maximum = new int[100000];
        Array.Fill(maximum, 10000);
        int[] expectedMaximum = new int[50001];
        Array.Fill(expectedMaximum, 10000);
        RunTest("100000 elementos e janela grande", solution.MaxSlidingWindow(maximum, 50000), expectedMaximum);
        for (int i = 0; i < maximum.Length; i++)
        {
            maximum[i] = 10000 - i % 20001;
        }
        RunTest("100000 elementos em janela única", solution.MaxSlidingWindow(maximum, maximum.Length), new[] { 10000 });
        RunTest("Buffer circular cheio e reutilizado", solution.MaxSlidingWindow(maximum, 100), Reference(maximum, 100));

        Random random = new Random(239);
        for (int test = 0; test < 500; test++)
        {
            int[] values = new int[random.Next(1, 41)];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = random.Next(-5, 6);
            }
            int k = random.Next(1, values.Length + 1);
            RunTest($"Referência por varredura {test}", solution.MaxSlidingWindow(values, k), Reference(values, k));
        }
    }

    private static int[] Reference(int[] nums, int k)
    {
        int[] result = new int[nums.Length - k + 1];
        for (int left = 0; left < result.Length; left++)
        {
            int maximum = nums[left];
            for (int offset = 1; offset < k; offset++)
            {
                maximum = Math.Max(maximum, nums[left + offset]);
            }
            result[left] = maximum;
        }
        return result;
    }

    private static void RunTest(string name, int[] actual, int[] expected)
    {
        bool passed = actual.Length == expected.Length;
        for (int i = 0; passed && i < actual.Length; i++)
        {
            passed = actual[i] == expected[i];
        }
        Console.WriteLine($"{name}: {(passed ? "PASS" : "FAIL")}");
        if (!passed)
        {
            Console.WriteLine($"  Tamanhos esperado/obtido: {expected.Length}/{actual.Length}");
            Environment.ExitCode = 1;
        }
    }
}
