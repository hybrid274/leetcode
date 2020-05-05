public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int res = 0;
        for (int i = 0; i < 32; i++)
        {
            int sum = 0;
            for (int j = 0; j < nums.Length; j++)
                if (((nums[j] >> i) & 1) == 1)
                    sum++;
            sum %= 3;
            if (sum != 0)
                res += sum << i;
        }
        return res;
    }
}
