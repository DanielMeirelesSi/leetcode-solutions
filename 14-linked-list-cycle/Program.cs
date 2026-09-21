using System;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();

        ListNode cycleHead = new ListNode(3);
        cycleHead.next = new ListNode(2);
        cycleHead.next.next = new ListNode(0);
        cycleHead.next.next.next = new ListNode(-4);
        cycleHead.next.next.next.next = cycleHead.next;

        RunTest("Lista com ciclo", solution.HasCycle(cycleHead), true);
        RunTest("Lista sem ciclo", solution.HasCycle(CreateList(1, 2, 3)), false);
        RunTest("Lista com um nó sem ciclo", solution.HasCycle(new ListNode(1)), false);

        ListNode selfCycle = new ListNode(1);
        selfCycle.next = selfCycle;
        RunTest("Um nó apontando para si mesmo", solution.HasCycle(selfCycle), true);
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

    private static void RunTest(string name, bool actual, bool expected)
    {
        Console.WriteLine($"{name}: {(actual == expected ? "PASS" : "FAIL")}");
    }
}
