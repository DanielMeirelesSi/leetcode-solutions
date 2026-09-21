using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest(
            "Produtos dos elementos",
            new[] { 24, 12, 8, 6 },
            solution.ProductExceptSelf(new[] { 1, 2, 3, 4 }));

        RunTest(
            "Array contendo zero",
            new[] { 0, 0, 9, 0, 0 },
            solution.ProductExceptSelf(new[] { -1, 1, 0, -3, 3 }));

        RunTest(
            "Array pequeno com valores negativos",
            new[] { -1, -1 },
            solution.ProductExceptSelf(new[] { -1, -1 }));
    }

    private static void RunTest(string name, int[] expected, int[] actual)
    {
        Console.WriteLine($"{name}: {(AreEqual(expected, actual) ? "PASS" : "FAIL")}");
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
}
