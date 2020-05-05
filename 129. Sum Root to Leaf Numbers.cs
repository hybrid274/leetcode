public class Solution
{
    public int SumNumbers(TreeNode root)
    {
        return SumNumbersDFS(root, 0);
    }

    private int SumNumbersDFS(TreeNode root, int sum)
    {
        if (root == null)
            return 0;

        sum = sum * 10 + root.val;
        if (root.left == null && root.right == null)
            return sum;
        return SumNumbersDFS(root.left, sum) + SumNumbersDFS(root.right, sum);
    }
}
