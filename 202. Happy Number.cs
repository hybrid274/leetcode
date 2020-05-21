public class Solution
{
    public bool IsHappy(int n)
    {
        HashSet<int> hs = new HashSet<int>();
        for (int num = 0; n != 1; n = num, num = 0)
        {
            foreach (char c in n.ToString())
                num += (c - '0') * (c - '0');

            if (hs.Contains(num))
                return false;
            else
                hs.Add(num);
        }
        return true;
    }
}
