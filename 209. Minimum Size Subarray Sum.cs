public class Solution
{
    public int MinSubArrayLen(int s, int[] nums)
    {
        int res = int.MaxValue, left = 0, sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            while (left <= i && sum >= s)
            {
                res = Math.Min(res, i - left + 1);
                sum -= nums[left++];
            }
        }
        return res == int.MaxValue ? 0 : res;
    }
}
