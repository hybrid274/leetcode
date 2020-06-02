public class Solution
{
    TreeNode perv = null;
    public void Flatten(TreeNode root)
    {
        if (root == null)
            return;
        Flatten(root.right);
        Flatten(root.left);
        root.right = perv;
        root.left = null;
        perv = root;
    }
}
