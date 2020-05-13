public class Solution
{
    public IList<string> FindRepeatedDnaSequences(string s)
    {
        HashSet<string> res = new HashSet<string>();
        if (s.Length < 11)
            return res.ToList();
        HashSet<string> dict = new HashSet<string>();
        for (int i = 0; i < s.Length-9; i++)
        {
            string str = s.Substring(i, 10);
            if(!dict.Contains(str))
            {
                dict.Add(str);
                continue;
            }

            if (!res.Contains(str))
                res.Add(str);
        }
        return res.ToList();
    }
}
