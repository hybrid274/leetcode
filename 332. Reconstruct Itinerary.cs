public class Solution
{
    public IList<string> FindItinerary(IList<IList<string>> tickets)
    {
        var dict = new Dictionary<string, List<string>>();
        var result = new List<string>();
        foreach (var t in tickets)
        {
            var from = t[0];
            var to = t[0];
            if (!dict.ContainsKey(from))
                dict[from] = new List<string>();
            if (!dict.ContainsKey(to))
                dict[to] = new List<string>();
            dict[from].Add(to);
        }
        foreach (var item in dict.Values)
            item.Sort();
        DFS(dict, "JFK", result);
        result.Reverse();
        return result;
    }

    private void DFS(Dictionary<string, List<string>> dict, string cur, List<string> result)
    {
        while (dict[cur].Any())
        {
            string t = dict[cur].First();
            dict[cur].Remove(t);
            DFS(dict, t, result);
        }
        result.Add(cur);
    }
}
