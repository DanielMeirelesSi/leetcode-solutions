using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        RunTest("Exemplo oficial 1", solution.FindWords(CreateBoard("oaan", "etae", "ihkr", "iflv"), new[] { "oath", "pea", "eat", "rain" }), new[] { "eat", "oath" });
        RunTest("Exemplo oficial 2", solution.FindWords(CreateBoard("ab", "cd"), new[] { "abcb" }), new string[0]);
        RunTest("Uma célula", solution.FindWords(CreateBoard("a"), new[] { "a", "b", "aa" }), new[] { "a" });
        RunTest("Não pode usar diagonal", solution.FindWords(CreateBoard("ax", "xb"), new[] { "ab" }), new string[0]);
        RunTest("Prefixos compartilhados", solution.FindWords(CreateBoard("oath"), new[] { "o", "oa", "oat", "oath" }), new[] { "o", "oa", "oat", "oath" });
        RunTest("Vários caminhos sem duplicar resposta", solution.FindWords(CreateBoard("aa", "aa"), new[] { "a", "aa", "aaa", "aaaa", "aaaaa" }), new[] { "a", "aa", "aaa", "aaaa" });
        RunTest("Caminho com mudança de direção", solution.FindWords(CreateBoard("abc", "fed"), new[] { "abcdef", "abcfed", "cdefab" }), new[] { "abcdef", "cdefab" });
        RunTest("Profundidade máxima", solution.FindWords(CreateBoard("abcdefghij"), new[] { "abcdefghij", "jihgfedcba" }), new[] { "abcdefghij", "jihgfedcba" });
        char[][] maximumBoard = new char[12][];
        for (int row = 0; row < maximumBoard.Length; row++)
        {
            maximumBoard[row] = new string('a', 12).ToCharArray();
        }
        string[] maximumWords = new string[30000];
        maximumWords[0] = "a";
        maximumWords[1] = new string('a', 10);
        for (int i = 2; i < maximumWords.Length; i++)
        {
            int value = i - 2;
            char[] suffix = new char[4];
            for (int j = 0; j < suffix.Length; j++)
            {
                suffix[j] = (char)('a' + value % 26);
                value /= 26;
            }
            maximumWords[i] = "b" + new string(suffix);
        }
        RunTest("Tabuleiro e dicionário máximos", solution.FindWords(maximumBoard, maximumWords), new[] { "a", "aaaaaaaaaa" });

        string pattern = "acdefghijklmnopqrstuvwxyzbc";
        for (int row = 0; row < maximumBoard.Length; row++)
        {
            for (int column = 0; column < maximumBoard[row].Length; column++)
            {
                maximumBoard[row][column] = pattern[(row * 12 + column) % pattern.Length];
            }
        }
        for (int i = 0; i < maximumWords.Length; i++)
        {
            int value = i;
            char[] suffix = new char[4];
            for (int j = 0; j < suffix.Length; j++)
            {
                suffix[j] = (char)('a' + value % 26);
                value /= 26;
            }
            maximumWords[i] = "abcdef" + new string(suffix);
        }
        RunTest("Trie com 30000 palavras de dez letras", solution.FindWords(maximumBoard, maximumWords), new string[0]);

        Random random = new Random(212);
        for (int test = 0; test < 200; test++)
        {
            char[][] board = new char[random.Next(1, 4)][];
            int columns = random.Next(1, 4);
            for (int row = 0; row < board.Length; row++)
            {
                board[row] = new char[columns];
                for (int column = 0; column < columns; column++)
                {
                    board[row][column] = (char)('a' + random.Next(3));
                }
            }
            HashSet<string> unique = new HashSet<string>();
            while (unique.Count < 15)
            {
                char[] letters = new char[random.Next(1, 6)];
                for (int i = 0; i < letters.Length; i++)
                {
                    letters[i] = (char)('a' + random.Next(3));
                }
                unique.Add(new string(letters));
            }
            string[] words = new string[unique.Count];
            unique.CopyTo(words);
            List<string> expected = new List<string>();
            foreach (string word in words)
            {
                if (Reference(board, word))
                {
                    expected.Add(word);
                }
            }
            string before = Serialize(board);
            RunTest($"Referência palavra por palavra {test}", solution.FindWords(board, words), expected.ToArray());
            RunTest($"Tabuleiro restaurado {test}", new[] { Serialize(board) }, new[] { before });
            RunTest($"Chamadas repetidas {test}", solution.FindWords(board, words), expected.ToArray());
        }
    }

    private static char[][] CreateBoard(params string[] rows)
    {
        char[][] board = new char[rows.Length][];
        for (int i = 0; i < rows.Length; i++)
        {
            board[i] = rows[i].ToCharArray();
        }
        return board;
    }

    private static string Serialize(char[][] board)
    {
        string[] rows = new string[board.Length];
        for (int i = 0; i < board.Length; i++)
        {
            rows[i] = new string(board[i]);
        }
        return string.Join("/", rows);
    }

    private static bool Reference(char[][] board, string word)
    {
        for (int row = 0; row < board.Length; row++)
        {
            for (int column = 0; column < board[0].Length; column++)
            {
                if (ReferenceSearch(board, word, row, column, 0, 0))
                {
                    return true;
                }
            }
        }
        return false;
    }

    private static bool ReferenceSearch(char[][] board, string word, int row, int column, int index, int visited)
    {
        if (row < 0 || row >= board.Length || column < 0 || column >= board[0].Length)
        {
            return false;
        }
        int bit = 1 << (row * board[0].Length + column);
        if ((visited & bit) != 0 || board[row][column] != word[index])
        {
            return false;
        }
        if (index + 1 == word.Length)
        {
            return true;
        }
        visited |= bit;
        return ReferenceSearch(board, word, row - 1, column, index + 1, visited)
            || ReferenceSearch(board, word, row + 1, column, index + 1, visited)
            || ReferenceSearch(board, word, row, column - 1, index + 1, visited)
            || ReferenceSearch(board, word, row, column + 1, index + 1, visited);
    }

    private static void RunTest(string name, IList<string> actual, string[] expected)
    {
        List<string> sorted = new List<string>(actual);
        sorted.Sort(StringComparer.Ordinal);
        string[] expectedSorted = (string[])expected.Clone();
        Array.Sort(expectedSorted, StringComparer.Ordinal);
        bool passed = sorted.Count == expectedSorted.Length;
        for (int i = 0; passed && i < sorted.Count; i++)
        {
            passed = sorted[i] == expectedSorted[i];
        }
        Console.WriteLine($"{name}: {(passed ? "PASS" : "FAIL")}");
        if (!passed)
        {
            Console.WriteLine($"  Esperado: [{string.Join(",", expectedSorted)}]; obtido: [{string.Join(",", sorted)}]");
            Environment.ExitCode = 1;
        }
    }
}
