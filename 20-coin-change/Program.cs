using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Exemplo oficial", solution.CoinChange(new[] { 1, 2, 5 }, 11), 3);
        RunTest("Impossível", solution.CoinChange(new[] { 2 }, 3), -1);
        RunTest("Valor zero", solution.CoinChange(new[] { 1 }, 0), 0);
        RunTest("Greedy não funciona", solution.CoinChange(new[] { 1, 3, 4 }, 6), 2);
        RunTest("Moeda maior que o valor", solution.CoinChange(new[] { int.MaxValue, 2 }, 4), 2);
        RunTest("Denominações repetidas", solution.CoinChange(new[] { 2, 2, 1 }, 3), 2);
        RunTest("Sem moedas", solution.CoinChange(new int[0], 3), -1);
        RunTest("Valor máximo", solution.CoinChange(new[] { 1 }, 10000), 10000);
        RunTest("Combinação não trivial", solution.CoinChange(new[] { 186, 419, 83, 408 }, 6249), 20);
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
