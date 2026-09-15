using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Zeros entre valores", new[] { 1, 3, 12, 0, 0 }, solution, new[] { 0, 1, 0, 3, 12 });
        RunTest("Array com um zero", new[] { 0 }, solution, new[] { 0 });
        RunTest("Vários zeros intercalados", new[] { 1, 2, 3, 0, 0 }, solution, new[] { 1, 0, 2, 0, 3 });
    }

    private static void RunTest(string name, int[] expected, Solution solution, int[] values)
    {
        solution.MoveZeroes(values);
        Console.WriteLine($"{name}: {(AreEqual(expected, values) ? "PASS" : "FAIL")}");
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
