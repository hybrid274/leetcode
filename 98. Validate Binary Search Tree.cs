public class Solution
{
    public IList<IList<int>> FindSubsequences(int[] nums)
    {
        var result = new List<IList<int>>();
        DFS(nums, 0, new List<int>(), result);
        return result;
    }

    private void DFS(int[] nums, int startIndex, List<int> oneResult, List<IList<int>> result)
    {
        if (oneResult.Count > 1)
            result.Add(new List<int>(oneResult));
        HashSet<int> isVitied = new HashSet<int>();

        for (int i = startIndex; i < nums.Length; i++)
        {
            int cur = nums[i];
            if (isVitied.Contains(cur))
                continue;

            isVitied.Add(cur);
            oneResult.Add(cur);
            DFS(nums, i + 1, oneResult, result);
            oneResult.RemoveAt(oneResult.Count - 1);
        }
    }
}
