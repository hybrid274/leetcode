public class Solution
{
    public string DecodeString(string s)
    {
        int i = 0;
        return DFS(s, ref i, s.Length - 1);
    }

    private string DFS(string s, ref int i, int end)
    {
        StringBuilder sb = new StringBuilder();
        int num = 0;
        string res;
        while (i <= end)
        {
            if (s[i] == ']')
                return sb.ToString();
            else if (s[i] == '[')
            {
                i++;
                res = DFS(s, ref i, end);
                while (num > 0)
                {
                    sb.Append(res);
                    num--;
                }
            }
            else if (s[i] >= '0' && s[i] <= '9')
                num = num * 10 + s[i] - '0';
            else
                sb.Append(s[i]);
            i++;
        }
        return sb.ToString();
    }
}
