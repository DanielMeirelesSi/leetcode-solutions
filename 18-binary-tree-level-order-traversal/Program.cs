using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        TreeNode root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
        RunTest("Exemplo oficial", solution.LevelOrder(root), new[] { "3", "9,20", "15,7" });
        RunTest("Árvore vazia", solution.LevelOrder(null), new string[0]);
        RunTest("Um nó", solution.LevelOrder(new TreeNode(1)), new[] { "1" });
        RunTest("Valores repetidos", solution.LevelOrder(new TreeNode(2, new TreeNode(2), new TreeNode(2))), new[] { "2", "2,2" });
        RunTest("Árvore assimétrica", solution.LevelOrder(new TreeNode(0, new TreeNode(-1, null, new TreeNode(-2)), new TreeNode(1))), new[] { "0", "-1,1", "-2" });
        TreeNode chain = null;
        string[] levels = new string[2000];
        for (int i = 1999; i >= 0; i--)
        {
            chain = new TreeNode(i % 1000, null, chain);
            levels[i] = (i % 1000).ToString();
        }
        RunTest("Profundidade máxima", solution.LevelOrder(chain), levels);
    }

    private static void RunTest(string name, IList<IList<int>> actual, string[] expected)
    {
        bool passed = actual.Count == expected.Length;
        for (int i = 0; passed && i < expected.Length; i++)
        {
            passed = string.Join(",", actual[i]) == expected[i];
        }
        Console.WriteLine($"{name}: {(passed ? "PASS" : "FAIL")}");
        if (!passed)
        {
            Environment.ExitCode = 1;
        }
    }
}
