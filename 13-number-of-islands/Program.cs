using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest(
            "Uma ilha",
            solution.NumIslands(CreateGrid("11110", "11010", "11000", "00000")),
            1);

        RunTest(
            "Várias ilhas",
            solution.NumIslands(CreateGrid("11000", "11000", "00100", "00011")),
            3);

        RunTest(
            "Nenhuma ilha",
            solution.NumIslands(CreateGrid("000", "000")),
            0);
    }

    private static char[][] CreateGrid(params string[] rows)
    {
        char[][] grid = new char[rows.Length][];

        for (int i = 0; i < rows.Length; i++)
        {
            grid[i] = rows[i].ToCharArray();
        }

        return grid;
    }

    private static void RunTest(string name, int actual, int expected)
    {
        Console.WriteLine($"{name}: {(actual == expected ? "PASS" : "FAIL")}");
    }
}
