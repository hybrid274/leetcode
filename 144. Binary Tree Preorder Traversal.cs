public class Solution
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> result = new List<int>();
        if (root == null)
            return result;
        Stack<TreeNode> st = new Stack<TreeNode>();
        st.Push(root);

        while (st.Any())
        {
            TreeNode t = st.Pop();
            result.Add(t.val);
            if (t.right != null)
                st.Push(t.right);
            if (t.left != null)
                st.Push(t.left);
        }
        return result;
    }
}
