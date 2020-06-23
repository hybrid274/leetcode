public class Solution
{
    public IList<int> LargestValues(TreeNode root)
    {
        List<int> res = new List<int>();
        DFS(root, 0, res);
        return res;
    }

    private void DFS(TreeNode root, int level, List<int> res)
    {
        if (root == null)
            return;
        if (res.Count == level)
            res.Add(root.val);
        else
            res[level] = Math.Max(res[level], root.val);
        DFS(root.left, level + 1, res);
        DFS(root.right, level + 1, res);
    }
}
