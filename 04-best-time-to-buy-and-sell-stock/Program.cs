using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Cenário com lucro", solution.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 }), 5);
        RunTest("Sem possibilidade de lucro", solution.MaxProfit(new[] { 7, 6, 4, 3, 1 }), 0);
        RunTest("Compra e venda em sequência", solution.MaxProfit(new[] { 2, 4, 1 }), 2);
    }

    private static void RunTest(string name, int actual, int expected)
    {
        Console.WriteLine($"{name}: {(actual == expected ? "PASS" : "FAIL")}");
    }
}
