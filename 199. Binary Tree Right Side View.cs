public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        IList<int> list = new List<int>();
        if (root != null)
            queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int cnt = queue.Count;
            bool f = true;
            while (cnt-- > 0)
            {
                TreeNode node = queue.Dequeue();
                if (f)
                {
                    list.Add(node.val);
                    f = false;
                }
                if (node.right != null)
                    queue.Enqueue(node.right);
                if (node.left != null)
                    queue.Enqueue(node.left);
            }
        }
        return list;
    }
}
