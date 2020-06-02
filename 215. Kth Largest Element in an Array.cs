public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        return FindKthLargest(nums, 0, nums.Length, k);
    }

    private int FindKthLargest(int[] nums, int left, int right, int k)
    {
        int pos = partition(nums, left, right);
        if (pos - left == k - 1)
            return nums[pos];
        else if (pos - left < k - 1)
            return FindKthLargest(nums, pos + 1, right, k - (pos - left + 1));
        return FindKthLargest(nums, left, pos + 1, k);
    }

    private int partition(int[] nums, int left, int right)
    {
        int part = nums[right];
        int index = left;
        for (int i = left; i < right; i++)
        {
            if (nums[i] >= part)
            {
                swap(nums, i, index);
                index++;
            }
        }
        swap(nums, index, right);
        return index;
    }

    private void swap(int[] nums, int x, int y)
    {
        int temp = nums[x];
        nums[x] = nums[y];
        nums[y] = temp;
    }
}
