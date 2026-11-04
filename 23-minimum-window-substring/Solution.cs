public class Solution
{
    public string MinWindow(string s, string t)
    {
        if (t.Length == 0 || s.Length < t.Length)
        {
            return "";
        }

        int[] needed = new int[128];
        foreach (char character in t)
        {
            needed[character]++;
        }

        int missing = t.Length;
        int left = 0;
        int bestStart = 0;
        int bestLength = s.Length + 1;

        for (int right = 0; right < s.Length; right++)
        {
            if (needed[s[right]] > 0)
            {
                missing--;
            }
            needed[s[right]]--;

            while (missing == 0)
            {
                int length = right - left + 1;
                if (length < bestLength)
                {
                    bestStart = left;
                    bestLength = length;
                }

                needed[s[left]]++;
                if (needed[s[left]] > 0)
                {
                    missing++;
                }
                left++;
            }
        }

        return bestLength > s.Length ? "" : s.Substring(bestStart, bestLength);
    }
}
