using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("Anagrama válido", solution.IsAnagram("anagram", "nagaram"), true);
        RunTest("Anagrama inválido", solution.IsAnagram("rat", "car"), false);
        RunTest("Strings vazias", solution.IsAnagram("", ""), true);
    }

    private static void RunTest(string name, bool actual, bool expected)
    {
        Console.WriteLine($"{name}: {(actual == expected ? "PASS" : "FAIL")}");
    }
}
