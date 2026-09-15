using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        TreeNode tree = new TreeNode(3);
        tree.left = new TreeNode(9);
        tree.right = new TreeNode(20);
        tree.right.left = new TreeNode(15);
        tree.right.right = new TreeNode(7);

        RunTest("Árvore comum", solution.MaxDepth(tree), 3);
        RunTest("Árvore com um nó", solution.MaxDepth(new TreeNode(1)), 1);
        RunTest("Árvore vazia", solution.MaxDepth(null), 0);
    }

    private static void RunTest(string name, int actual, int expected)
    {
        Console.WriteLine($"{name}: {(actual == expected ? "PASS" : "FAIL")}");
    }
}
