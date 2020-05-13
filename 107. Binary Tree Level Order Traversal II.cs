public class Solution
{
    public IList<IList<int>> LevelOrderBottom(TreeNode root)
    {
        IList<IList<int>> res = new List<IList<int>>();
        DFS(res, 0, root);
        return res.Reverse().ToList();
    }

    private void DFS(IList<IList<int>> res, int level, TreeNode node)
    {
        if (node == null)
            return;
        if (res.Count == level)
            res.Add(new List<int>());
        res[level].Add(node.val);
        DFS(res, level + 1, node.left);
        DFS(res, level + 1, node.right);
    }
}
