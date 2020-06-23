public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();
        if (root == null)
            return result;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Any())
        {
            var size = queue.Count;
            var oneResult = new List<int>();
            for (int i = 0; i < size; i++)
            {
                var cur = queue.Dequeue();
                oneResult.Add(cur.val);

                if (cur.left != null) queue.Enqueue(cur.left);
                if (cur.right != null) queue.Enqueue(cur.right);
            }
            result.Add(oneResult);
        }
        return result;
    }
}
