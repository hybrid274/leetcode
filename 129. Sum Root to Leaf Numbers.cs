public class Solution
{
    public int SumNumbers(TreeNode root)
    {
        return DFS(root, 0);
    }

    private int DFS(TreeNode root, int sum)
    {
        if (root == null)
            return 0;
        int cur = sum * 10 + root.val;
        if (root.left == null && root.right == null)
            return cur;
        return DFS(root.left, cur) + DFS(root.right, cur);
    }
}
