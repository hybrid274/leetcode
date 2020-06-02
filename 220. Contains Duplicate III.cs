public class Solution
{
    public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
    {
        if (t < 0) return false;
        var sortedSet = new SortedSet<long>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (sortedSet.GetViewBetween((long)nums[i] - t, (long)nums[i] + t).Count > 0) return true;
            sortedSet.Add(nums[i]);
            if (i >= k) sortedSet.Remove(nums[i - k]);
        }
        return false;
    }
}
