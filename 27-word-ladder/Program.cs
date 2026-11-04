using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        RunTest("Exemplo oficial 1", solution.LadderLength("hit", "cog", new[] { "hot", "dot", "dog", "lot", "log", "cog" }), 5);
        RunTest("Exemplo oficial 2", solution.LadderLength("hit", "cog", new[] { "hot", "dot", "dog", "lot", "log" }), 0);
        RunTest("Uma letra", solution.LadderLength("a", "c", new[] { "a", "b", "c" }), 2);
        RunTest("Destino presente mas desconectado", solution.LadderLength("aaa", "bbb", new[] { "bbb" }), 0);
        RunTest("Origem no dicionário", solution.LadderLength("hit", "hot", new[] { "hit", "hot" }), 2);
        RunTest("Caminhos convergentes", solution.LadderLength("red", "tax", new[] { "ted", "tex", "red", "tax", "tad", "den", "rex", "pee" }), 4);
        List<string> chain = new List<string>();
        for (int i = 1; i <= 10; i++)
        {
            chain.Add(new string('b', i) + new string('a', 10 - i));
        }
        RunTest("Dez transformações", solution.LadderLength(new string('a', 10), new string('b', 10), chain), 11);
        List<string> maximum = new List<string>();
        for (int i = 0; i < 5000; i++)
        {
            maximum.Add("aaaaaaa" + Encode(i));
        }
        RunTest("5000 palavras com dez letras", solution.LadderLength("aaaaaaaaaa", "aaaaaaahkh", maximum), 4);

        Random random = new Random(127);
        for (int test = 0; test < 300; test++)
        {
            List<string> dictionary = new List<string>();
            for (int value = 0; value < 27; value++)
            {
                if (random.Next(2) == 0)
                {
                    dictionary.Add(SmallWord(value));
                }
            }
            if (dictionary.Count == 0)
            {
                dictionary.Add("aaa");
            }
            string begin = SmallWord(random.Next(27));
            string end;
            do
            {
                end = SmallWord(random.Next(27));
            } while (end == begin);
            RunTest($"Referência Floyd-Warshall {test}", solution.LadderLength(begin, end, dictionary), Reference(begin, end, dictionary));
        }
    }

    private static string Encode(int value)
    {
        return new string(new[] { (char)('a' + value % 26), (char)('a' + value / 26 % 26), (char)('a' + value / 676) });
    }

    private static string SmallWord(int value)
    {
        return new string(new[] { (char)('a' + value % 3), (char)('a' + value / 3 % 3), (char)('a' + value / 9) });
    }

    private static int Reference(string begin, string end, List<string> dictionary)
    {
        if (!dictionary.Contains(end))
        {
            return 0;
        }
        List<string> vertices = new List<string>(dictionary);
        if (!vertices.Contains(begin))
        {
            vertices.Add(begin);
        }
        int count = vertices.Count;
        int[,] distance = new int[count, count];
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < count; j++)
            {
                int differences = 0;
                for (int letter = 0; letter < begin.Length; letter++)
                {
                    if (vertices[i][letter] != vertices[j][letter])
                    {
                        differences++;
                    }
                }
                distance[i, j] = i == j ? 0 : differences == 1 ? 1 : 1000;
            }
        }
        for (int middle = 0; middle < count; middle++)
        {
            for (int from = 0; from < count; from++)
            {
                for (int to = 0; to < count; to++)
                {
                    distance[from, to] = Math.Min(distance[from, to], distance[from, middle] + distance[middle, to]);
                }
            }
        }
        int edges = distance[vertices.IndexOf(begin), vertices.IndexOf(end)];
        return edges == 1000 ? 0 : edges + 1;
    }

    private static void RunTest(string name, int actual, int expected)
    {
        bool passed = actual == expected;
        Console.WriteLine($"{name}: {(passed ? "PASS" : "FAIL")}");
        if (!passed)
        {
            Console.WriteLine($"  Esperado: {expected}; obtido: {actual}");
            Environment.ExitCode = 1;
        }
    }
}
