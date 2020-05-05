public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        List<IList<string>> res = new List<IList<string>>();
        DFS(s, 0, new List<string>(), res);
        return res;
    }

    private void DFS(string s, int start, List<string> oneRes, List<IList<string>> res)
    {
        if (s.Length == start)
        {
            res.Add(new List<string>(oneRes));
            return;
        }

        for (int i = start; i < s.Length; i++)
        {
            if (!IsPalinerome(s, start, i))
                continue;
            oneRes.Add(s.Substring(start, i - start + 1));
            DFS(s, i + 1, oneRes, res);
            oneRes.RemoveAt(oneRes.Count - 1);
        }
    }

    private bool IsPalinerome(string s, int start, int end)
    {
        while (start < end)
        {
            if (s[start] != s[end])
                return false;
            start++;
            end--;
        }
        return true;
    }
}
