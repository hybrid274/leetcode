public class Solution
{
    public int CompareVersion(string version1, string version2)
    {
        string[] ver1s = version1.Split('.');
        string[] ver2s = version2.Split('.');
        int i = 0;
        while (i < ver1s.Length || i < ver2s.Length)
        {
            int v1 = i < ver1s.Length ? int.Parse(ver1s[i]) : 0;
            int v2 = i < ver2s.Length ? int.Parse(ver2s[i]) : 0;
            if (v1 > v2)
                return 1;
            else if (v1 < v2)
                return -1;
            i++;
        }
        return 0;
    }
}
