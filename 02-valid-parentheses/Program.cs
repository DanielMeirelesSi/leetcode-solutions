using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Expressão válida", solution.IsValid("()[]{}"), true);
        RunTest("Expressão inválida", solution.IsValid("(]"), false);
        RunTest("Tipos combinados", solution.IsValid("([{}])"), true);
    }

    private static void RunTest(string name, bool actual, bool expected)
    {
        Console.WriteLine($"{name}: {(actual == expected ? "PASS" : "FAIL")}");
    }
}
