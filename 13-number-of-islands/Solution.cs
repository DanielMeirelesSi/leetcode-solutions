using System.Collections.Generic;

public class Solution
{
    public int NumIslands(char[][] grid)
    {
        if (grid == null || grid.Length == 0)
        {
            return 0;
        }

        int islands = 0;

        for (int row = 0; row < grid.Length; row++)
        {
            for (int column = 0; column < grid[row].Length; column++)
            {
                if (grid[row][column] != '1')
                {
                    continue;
                }

                islands++;
                MarkIsland(grid, row, column);
            }
        }

        return islands;
    }

    private void MarkIsland(char[][] grid, int row, int column)
    {
        Stack<(int Row, int Column)> cells = new Stack<(int Row, int Column)>();
        cells.Push((row, column));
        grid[row][column] = '0';

        while (cells.Count > 0)
        {
            (int currentRow, int currentColumn) = cells.Pop();

            if (currentRow > 0 && grid[currentRow - 1][currentColumn] == '1')
            {
                grid[currentRow - 1][currentColumn] = '0';
                cells.Push((currentRow - 1, currentColumn));
            }

            if (currentRow + 1 < grid.Length && grid[currentRow + 1][currentColumn] == '1')
            {
                grid[currentRow + 1][currentColumn] = '0';
                cells.Push((currentRow + 1, currentColumn));
            }

            if (currentColumn > 0 && grid[currentRow][currentColumn - 1] == '1')
            {
                grid[currentRow][currentColumn - 1] = '0';
                cells.Push((currentRow, currentColumn - 1));
            }

            if (currentColumn + 1 < grid[currentRow].Length && grid[currentRow][currentColumn + 1] == '1')
            {
                grid[currentRow][currentColumn + 1] = '0';
                cells.Push((currentRow, currentColumn + 1));
            }
        }
    }
}
