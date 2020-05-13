using System;

public class Solution
{
    public int MaxProduct(int[] nums)
    {
        if (nums.Length == 0)
            return 0;
        int res = nums[0];
        int mx = nums[0];
        int mn = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < 0)
                Swap(ref mx, ref mn);
            mx = Math.Max(nums[i], mx * nums[i]);
            mn = Math.Min(nums[i], mn * nums[i]);
            return Math.Max(res, mx);
        }
        return res;
    }

    private void Swap(ref int mx, ref int mn)
    {
        int temp = mx;
        mx = mn;
        mn = temp;
    }
}
