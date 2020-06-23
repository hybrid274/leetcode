public class Solution
{
    public IList<IList<int>> FindSubsequences(int[] nums)
    {
        var result = new List<IList<int>>();
        DFS(nums, 0, new List<int>(), result);
        return result;
    }

    private void DFS(int[] nums, int startIndex, List<int> list, List<IList<int>> result)
    {
        if (list.Count > 1)
            result.Add(new List<int>(list));

        var isVisited = new HashSet<int>();

        for (int i = startIndex; i < nums.Length; i++)
        {
            var cur = nums[i];
            if (isVisited.Contains(cur))
                continue;
            if (!list.Any() || list.Last() <= cur)
            {
                isVisited.Add(cur);
                list.Add(cur);
                DFS(nums, i + 1, list, result);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
