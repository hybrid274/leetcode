public class Solution
{
    public int Rob(TreeNode root)
    {
        var dict = new Dictionary<TreeNode, int>();
        return DFS(root, dict);
    }

    private int DFS(TreeNode root, Dictionary<TreeNode, int> dict)
    {
        if (root == null) return 0;
        if (dict.ContainsKey(root)) return dict[root];
        int val = 0;
        if (root.left != null)
            val += DFS(root.left.left, dict) + DFS(root.left.right, dict);
        if (root.right != null)
            val += DFS(root.right.left, dict) + DFS(root.right.right, dict);
        val = Math.Max(val + root.val, DFS(root.left, dict) + DFS(root.right, dict));
        dict[root] = val;
        return val;
    }
}
