using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Exemplo oficial", solution.MinWindow("ADOBECODEBANC", "ABC"), "BANC");
        RunTest("Um caractere", solution.MinWindow("a", "a"), "a");
        RunTest("Frequência insuficiente", solution.MinWindow("a", "aa"), "");
        RunTest("Repetições necessárias", solution.MinWindow("XAAACBY", "AABC"), "AACB");
        RunTest("Maiúsculas e minúsculas", solution.MinWindow("aA", "A"), "A");
        RunTest("Caractere ausente", solution.MinWindow("abc", "d"), "");
        RunTest("Janela no final", solution.MinWindow("aaab", "ab"), "ab");
        RunTest("Origem vazia", solution.MinWindow("", "a"), "");
        RunTest("Alvo vazio", solution.MinWindow("abc", ""), "");
        RunTest("Entrada longa", solution.MinWindow(new string('a', 99999) + "b", "ab"), "ab");
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
