using System.Collections.Generic;

public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        HashSet<string> remaining = new HashSet<string>(wordList);
        if (!remaining.Contains(endWord))
        {
            return 0;
        }

        Queue<string> words = new Queue<string>();
        words.Enqueue(beginWord);
        remaining.Remove(beginWord);
        int length = 1;

        while (words.Count > 0)
        {
            int levelSize = words.Count;
            for (int i = 0; i < levelSize; i++)
            {
                char[] letters = words.Dequeue().ToCharArray();
                for (int position = 0; position < letters.Length; position++)
                {
                    char original = letters[position];
                    for (char replacement = 'a'; replacement <= 'z'; replacement++)
                    {
                        if (replacement == original)
                        {
                            continue;
                        }

                        letters[position] = replacement;
                        string next = new string(letters);
                        if (!remaining.Remove(next))
                        {
                            continue;
                        }
                        if (next == endWord)
                        {
                            return length + 1;
                        }
                        words.Enqueue(next);
                    }
                    letters[position] = original;
                }
            }
            length++;
        }

        return 0;
    }
}
