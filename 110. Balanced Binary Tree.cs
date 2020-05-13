public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        return !(CheckLenght(root) == -1);
    }

    private int CheckLenght(TreeNode root)
    {
        if (root == null)
            return 0;
        int left = CheckLenght(root.left);
        if (left == -1)
            return -1;
        int right = CheckLenght(root.right);
        if (right == -1)
            return -1;
        int diff = Math.Abs(left - right);
        if (diff > 1)
            return -1;
        return 1 + Math.Max(left, right);
    }
}
