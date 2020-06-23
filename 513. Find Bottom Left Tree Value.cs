public class Solution
{
    private int maxLevel = 0;
    private int result = 0;

    public int FindBottomLeftValue(TreeNode root)
    {
        DFS(root, 1);
        return result;
    }

    private void DFS(TreeNode root, int curLevel)
    {
        if (root == null)
            return;
        if (curLevel > maxLevel)
        {
            maxLevel = curLevel;
            result = root.val;
        }
        if (root.left != null)
            DFS(root.left, curLevel + 1);
        if (root.right != null)
            DFS(root.right, curLevel + 1);
    }
}
