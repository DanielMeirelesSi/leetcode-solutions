using System.Collections.Generic;

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> openingBrackets = new Stack<char>();

        foreach (char character in s)
        {
            if (character == '(' || character == '[' || character == '{')
            {
                openingBrackets.Push(character);
                continue;
            }

            if (openingBrackets.Count == 0 || !Matches(openingBrackets.Pop(), character))
            {
                return false;
            }
        }

        return openingBrackets.Count == 0;
    }

    private bool Matches(char opening, char closing)
    {
        return (opening == '(' && closing == ')')
            || (opening == '[' && closing == ']')
            || (opening == '{' && closing == '}');
    }
}
