public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        bool[] dp = new bool[s.Length + 1];
        dp[0] = true;
        for (int i = 0; i < dp.Length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (dp[j] && wordDict.Contains(s.Substring(j, i - j)))
                {
                    dp[i] = true;
                    break;
                }
            }
        }
        return dp[dp.Length - 1];
    }
}
