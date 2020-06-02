public class Solution
{
    public IList<IList<int>> PathSum(TreeNode root, int sum)
    {
        List<IList<int>> result = new List<IList<int>>();
        DFS(root, sum, new List<int>(), result);
        return result;
    }

    private void DFS(TreeNode root, int sum, List<int> oneResult, List<IList<int>> result)
    {
        if (root == null)
            return;
        oneResult.Add(root.val);
        if (root.val == sum && root.left == null && root.right == null)
            result.Add(new List<int>(oneResult));
        DFS(root.left, sum - root.val, oneResult, result);
        DFS(root.right, sum - root.val, oneResult, result);
        oneResult.RemoveAt(oneResult.Count - 1);
    }
}
