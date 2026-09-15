using System.Collections.Generic;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        Dictionary<char, int> lastSeen = new Dictionary<char, int>();
        int left = 0;
        int maximumLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char character = s[right];

            if (lastSeen.TryGetValue(character, out int previousIndex) && previousIndex >= left)
            {
                left = previousIndex + 1;
            }

            lastSeen[character] = right;
            int currentLength = right - left + 1;

            if (currentLength > maximumLength)
            {
                maximumLength = currentLength;
            }
        }

        return maximumLength;
    }
}
