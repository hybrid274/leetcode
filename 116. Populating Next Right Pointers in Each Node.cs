public class Solution
{
    public Node Connect(Node root)
    {
        if (root == null)
            return null;

        if (root.left != null)
            root.left.next = root.right;
        if (root.right != null)
            root.right.next = root.next != null ? root.next.left : null;
        Connect(root.left);
        Connect(root.right);
        return root;
    }
}
