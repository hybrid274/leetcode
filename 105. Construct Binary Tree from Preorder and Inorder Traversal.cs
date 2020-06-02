public class Solution
{
    public TreeNode BuildTree(int[] preorder, int[] inorder)
    {
        return DFS(preorder, inorder, 0, preorder.Length - 1, 0, inorder.Length - 1);
    }

    private TreeNode DFS(int[] preorder, int[] inorder, int lp, int rp, int li, int ri)
    {
        if (lp > rp) return null;
        TreeNode node = new TreeNode(preorder[lp]);
        for (int i = li; i <= ri; i++)
        {
            if (inorder[i] == preorder[lp])
            {
                node.left = DFS(preorder, inorder, lp + 1, lp + (i - li), li, i - 1);
                node.right = DFS(preorder, inorder, lp + 1 + (i - li), rp, i + 1, ri);
            }
        }
        return node;
    }
}
