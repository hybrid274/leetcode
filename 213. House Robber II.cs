public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length <= 1)
            return nums.Length == 0 ? 0 : nums[0];
        return Math.Max(Rob(nums, 0, nums.Length - 1), Rob(nums, 1, nums.Length));
    }

    private int Rob(int[] nums, int left, int right)
    {
        int rob = 0;
        int notRob = 0;
        for (int i = left; i < right; i++)
        {
            int preRob = rob;
            int preNotRob = notRob;
            rob = preNotRob + nums[i];
            notRob = Math.Max(preRob, preNotRob);
        }
        return Math.Max(rob, notRob);
    }
}
