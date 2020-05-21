public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 0)
            return 0;
        if (nums.Length == 1)
            return nums[0];
        int prePre = 0;
        int pre = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            int cur = Math.Max(prePre + nums[i], pre);
            prePre = pre;
            pre = cur;
        }
        return pre;
    }
}
