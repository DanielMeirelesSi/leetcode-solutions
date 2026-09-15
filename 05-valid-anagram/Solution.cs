using System.Collections.Generic;

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> frequencies = new Dictionary<char, int>();

        foreach (char character in s)
        {
            if (frequencies.ContainsKey(character))
            {
                frequencies[character]++;
            }
            else
            {
                frequencies[character] = 1;
            }
        }

        foreach (char character in t)
        {
            if (!frequencies.TryGetValue(character, out int frequency))
            {
                return false;
            }

            if (frequency == 1)
            {
                frequencies.Remove(character);
            }
            else
            {
                frequencies[character] = frequency - 1;
            }
        }

        return frequencies.Count == 0;
    }
}
