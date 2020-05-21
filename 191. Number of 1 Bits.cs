public class Solution
{
    public int HammingWeight(uint n)
    {
        int cnt = 0;
        for (int i = 0; i < 32; i++)
            if ((n >> i & 1) == 1)
                cnt++;
        return cnt;
    }
}
