using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Array básico", AreEqual(new[] { 0, 1 }, solution.TwoSum(new[] { 2, 7, 11, 15 }, 9)));
        RunTest("Valores duplicados", AreEqual(new[] { 0, 1 }, solution.TwoSum(new[] { 3, 3 }, 6)));
        RunTest("Índices no meio do array", AreEqual(new[] { 1, 2 }, solution.TwoSum(new[] { 3, 2, 4 }, 6)));
    }

    private static bool AreEqual(int[] expected, int[] actual)
    {
        if (expected.Length != actual.Length)
        {
            return false;
        }

        for (int i = 0; i < expected.Length; i++)
        {
            if (expected[i] != actual[i])
            {
                return false;
            }
        }

        return true;
    }

    private static void RunTest(string name, bool passed)
    {
        Console.WriteLine($"{name}: {(passed ? "PASS" : "FAIL")}");
    }
}
