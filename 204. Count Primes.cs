public class Solution
{
    public int CountPrimes(int n)
    {
        int res = 0;
        bool[] prime = new bool[n];
        for (int i = 2; i < n; i++)
        {
            if (prime[i])
                continue;
            res++;
            for (int j = 2; i * j < n; j++)
                prime[i * j] = true;
        }
        return res;
    }
}
