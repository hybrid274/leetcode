public class Solution
{
    public void Flatten(TreeNode root)
    {
        if (root == null)
            return;

        if (root.left != null)
            Flatten(root.left);
        if (root.right != null)
            Flatten(root.right);

        TreeNode tmp = root.right;
        root.right = root.left;
        root.left = null;

        while (root.right != null)
            root = root.right;
        root.right = tmp;
    }
}
