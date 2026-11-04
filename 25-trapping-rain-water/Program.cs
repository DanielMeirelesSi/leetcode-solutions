using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Exemplo oficial", solution.Trap(new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 }), 6);
        RunTest("Múltiplas depressões", solution.Trap(new[] { 4, 2, 0, 3, 2, 5 }), 9);
        RunTest("Crescente", solution.Trap(new[] { 1, 2, 3, 4 }), 0);
        RunTest("Decrescente", solution.Trap(new[] { 4, 3, 2, 1 }), 0);
        RunTest("Alturas iguais", solution.Trap(new[] { 3, 3, 3 }), 0);
        RunTest("Uma depressão", solution.Trap(new[] { 3, 0, 3 }), 3);
        RunTest("Limite menor à direita", solution.Trap(new[] { 5, 0, 1 }), 1);
        RunTest("Uma barra", solution.Trap(new[] { 2 }), 0);
        RunTest("Entrada vazia", solution.Trap(new int[0]), 0);
        int[] maximum = new int[20000];
        maximum[0] = 100000;
        maximum[maximum.Length - 1] = 100000;
        RunTest("Volume máximo", solution.Trap(maximum), 1999800000);
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
