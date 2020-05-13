public class BSTIterator
{
    Stack<TreeNode> stack = new Stack<TreeNode>();
    public BSTIterator(TreeNode root)
    {
        while (root != null)
        {
            stack.Push(root);
            root = root.left;
        }
    }

    /** @return the next smallest number */
    public int Next()
    {
        TreeNode next = stack.Pop();
        if (next.right != null)
        {
            TreeNode cur = next.right;
            while (cur != null)
            {
                stack.Push(cur);
                cur = cur.left;
            }
        }
        return next.val;
    }

    /** @return whether we have a next smallest number */
    public bool HasNext()
    {
        return stack.Any();
    }
}
