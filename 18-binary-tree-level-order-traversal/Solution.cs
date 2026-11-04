using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        List<IList<int>> levels = new List<IList<int>>();
        if (root == null)
        {
            return levels;
        }

        Queue<TreeNode> nodes = new Queue<TreeNode>();
        nodes.Enqueue(root);

        while (nodes.Count > 0)
        {
            int levelSize = nodes.Count;
            List<int> level = new List<int>(levelSize);

            for (int i = 0; i < levelSize; i++)
            {
                TreeNode node = nodes.Dequeue();
                level.Add(node.val);
                if (node.left != null)
                {
                    nodes.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    nodes.Enqueue(node.right);
                }
            }

            levels.Add(level);
        }

        return levels;
    }
}
