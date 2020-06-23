public class Solution
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        List<IList<int>> result = new List<IList<int>>();
        if (root == null) return result;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Any())
        {
            int size = queue.Count;
            var oneResult = new List<int>();
            for (int i = 0; i < size; i++)
            {
                var cur = queue.Dequeue();
                oneResult.Add(cur.val);
                if (cur.left != null) queue.Enqueue(cur.left);
                if (cur.right != null) queue.Enqueue(cur.right);
            }
            if (result.Count % 2 == 1)
                oneResult.Reverse();
            result.Add(oneResult);
        }
        return result;
    }
}
