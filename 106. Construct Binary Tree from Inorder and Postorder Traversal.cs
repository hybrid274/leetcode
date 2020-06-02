public class Solution
{
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        return DFS(inorder, postorder, 0, inorder.Length - 1, 0, postorder.Length - 1);
    }

    private TreeNode DFS(int[] inorder, int[] postorder, int li, int ri, int lp, int rp)
    {
        if (li > ri || lp > rp)
            return null;
        TreeNode cur = new TreeNode(postorder[rp]);
        int p = 0;
        for (int i = 0; i <= ri - li; i++)
        {
            if (inorder[li + i] == cur.val)
            {
                p = i;
                break;
            }
        }
        cur.left = DFS(inorder, postorder, li, li + p - 1, lp, lp + p - 1);
        cur.right = DFS(inorder, postorder, li + p + 1, ri, lp + p, rp - 1);
        return cur;
    }
}
