using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        RunTest(
            "Duas listas com valores repetidos",
            new[] { 1, 1, 2, 3, 4, 4 },
            ToArray(solution.MergeTwoLists(CreateList(1, 2, 4), CreateList(1, 3, 4))));

        RunTest(
            "Uma lista vazia",
            new[] { 0 },
            ToArray(solution.MergeTwoLists(null, CreateList(0))));

        RunTest(
            "Segunda lista vazia",
            new[] { 1, 5, 7 },
            ToArray(solution.MergeTwoLists(CreateList(1, 5, 7), null)));
    }

    private static ListNode CreateList(params int[] values)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        foreach (int value in values)
        {
            current.next = new ListNode(value);
            current = current.next;
        }

        return dummy.next;
    }

    private static int[] ToArray(ListNode head)
    {
        List<int> values = new List<int>();

        while (head != null)
        {
            values.Add(head.val);
            head = head.next;
        }

        return values.ToArray();
    }

    private static void RunTest(string name, int[] expected, int[] actual)
    {
        Console.WriteLine($"{name}: {(AreEqual(expected, actual) ? "PASS" : "FAIL")}");
    }

    private static bool AreEqual(int[] expected, int[] actual)
    {
        if (expected.Length != actual.Length)
        {
            return false;
        }

        for (int i = 0; i < expected.Length; i++)
        {
            if (expected[i] != actual[i])
            {
                return false;
            }
        }

        return true;
    }
}
