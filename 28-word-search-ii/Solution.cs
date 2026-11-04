using System.Collections.Generic;

public class Solution
{
    private class TrieNode
    {
        public TrieNode[] Children = new TrieNode[26];
        public int ChildCount;
        public string Word;
    }

    public IList<string> FindWords(char[][] board, string[] words)
    {
        int[] available = new int[26];
        foreach (char[] row in board)
        {
            foreach (char letter in row)
            {
                available[letter - 'a']++;
            }
        }

        TrieNode root = new TrieNode();
        foreach (string word in words)
        {
            if (word.Length > board.Length * board[0].Length || !CanFit(word, available))
            {
                continue;
            }

            TrieNode node = root;
            foreach (char letter in word)
            {
                int index = letter - 'a';
                if (node.Children[index] == null)
                {
                    node.Children[index] = new TrieNode();
                    node.ChildCount++;
                }
                node = node.Children[index];
            }
            node.Word = word;
        }

        List<string> found = new List<string>();
        for (int row = 0; row < board.Length && root.ChildCount > 0; row++)
        {
            for (int column = 0; column < board[0].Length && root.ChildCount > 0; column++)
            {
                Search(board, row, column, root, found);
            }
        }
        return found;
    }

    private bool CanFit(string word, int[] available)
    {
        int[] required = new int[26];
        foreach (char letter in word)
        {
            int index = letter - 'a';
            required[index]++;
            if (required[index] > available[index])
            {
                return false;
            }
        }
        return true;
    }

    private void Search(char[][] board, int row, int column, TrieNode parent, List<string> found)
    {
        if (row < 0 || row >= board.Length || column < 0 || column >= board[0].Length || board[row][column] == '#')
        {
            return;
        }

        char letter = board[row][column];
        int index = letter - 'a';
        TrieNode node = parent.Children[index];
        if (node == null)
        {
            return;
        }

        if (node.Word != null)
        {
            found.Add(node.Word);
            node.Word = null;
        }

        board[row][column] = '#';
        if (node.ChildCount > 0)
        {
            Search(board, row - 1, column, node, found);
            Search(board, row + 1, column, node, found);
            Search(board, row, column - 1, node, found);
            Search(board, row, column + 1, node, found);
        }
        board[row][column] = letter;

        if (node.Word == null && node.ChildCount == 0)
        {
            parent.Children[index] = null;
            parent.ChildCount--;
        }
    }
}
