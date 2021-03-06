public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        List<int> res = new List<int>();
        DFS(root, 1, res);
        return res;
    }

    private void DFS(TreeNode root, int level, List<int> res)
    {
        if (root == null)
            return;
        if (level > res.Count) res.Add(root.val);
        DFS(root.right, level + 1, res);
        DFS(root.left, level + 1, res);
    }
}
