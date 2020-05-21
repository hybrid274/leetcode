public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int res = 0;
        int cnt = 0;
        foreach (var num in nums)
        {
            if (cnt == 0)
            {
                res = num;
                cnt++;
            }
            else if (num == res)
                cnt++;
            else
                cnt--;
        }
        return res;
    }
}
