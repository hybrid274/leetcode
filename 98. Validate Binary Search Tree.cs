public class Solution
{
    public bool IsValidBST(TreeNode root)
    {
        return DFS(root, long.MinValue, long.MaxValue);
    }

    private bool DFS(TreeNode root, long minValue, long maxValue)
    {
        if (root == null) return true;
        if (root.val <= minValue || root.val >= maxValue) return false;
        return DFS(root.left, minValue, root.val) && DFS(root.right, root.val, maxValue);
    }
}
