public class Solution
{
    public Node Connect(Node root)
    {
        if (root == null)
            return null;

        Node p = root.next;
        while (p != null)
        {
            if (p.left != null)
            {
                p = p.left;
                break;
            }
            if (p.right != null)
            {
                p = p.right;
                break;
            }
            p = p.next;
        }
        if (root.right != null)
            root.right.next = p;
        if (root.left != null)
            root.left.next = root.right != null ? root.right : p;
        Connect(root.right);
        Connect(root.left);
        return root;
    }
}
