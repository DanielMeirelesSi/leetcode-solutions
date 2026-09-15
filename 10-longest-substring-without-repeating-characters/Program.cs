using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest("String sem repetição", solution.LengthOfLongestSubstring("abc"), 3);
        RunTest("String com repetição", solution.LengthOfLongestSubstring("abcabcbb"), 3);
        RunTest("String vazia", solution.LengthOfLongestSubstring(""), 0);
    }

    private static void RunTest(string name, int actual, int expected)
    {
        Console.WriteLine($"{name}: {(actual == expected ? "PASS" : "FAIL")}");
    }
}
