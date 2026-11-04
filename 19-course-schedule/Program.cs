using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Dependência simples", solution.CanFinish(2, new[] { new[] { 1, 0 } }), true);
        RunTest("Ciclo", solution.CanFinish(2, new[] { new[] { 1, 0 }, new[] { 0, 1 } }), false);
        RunTest("Sem pré-requisitos", solution.CanFinish(3, new int[0][]), true);
        RunTest("Autodependência", solution.CanFinish(1, new[] { new[] { 0, 0 } }), false);
        RunTest("Dependências convergentes", solution.CanFinish(4, new[] { new[] { 1, 0 }, new[] { 2, 0 }, new[] { 3, 1 }, new[] { 3, 2 } }), true);
        RunTest("Ciclo desconectado", solution.CanFinish(5, new[] { new[] { 1, 0 }, new[] { 3, 2 }, new[] { 2, 3 } }), false);
        RunTest("Aresta repetida", solution.CanFinish(2, new[] { new[] { 1, 0 }, new[] { 1, 0 } }), true);
        int[][] chain = new int[1999][];
        for (int i = 0; i < chain.Length; i++)
        {
            chain[i] = new[] { i + 1, i };
        }
        RunTest("Cadeia com 2000 cursos", solution.CanFinish(2000, chain), true);
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
