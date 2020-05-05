public class Solution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        HashSet<string> wordSet = new HashSet<string>(wordList);

        if (!wordSet.Contains(endWord))
            return 0;

        Queue<string> q = new Queue<string>();
        q.Enqueue(beginWord);
        int res = 0;

        while (q.Any())
        {
            for (int k = q.Count; k > 0; k--)
            {
                string word = q.Dequeue();
                if (word == endWord)
                    return res + 1;
                for (int i = 0; i < word.Length; i++)
                {
                    char[] newWord = word.ToArray();
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        newWord[i] = c;
                        string next = new string(newWord);
                        if (wordSet.Contains(next) && next != word)
                        {
                            q.Enqueue(next);
                            wordSet.Remove(next);
                        }
                    }
                }
            }
            res++;
        }
        return 0;
    }
}
