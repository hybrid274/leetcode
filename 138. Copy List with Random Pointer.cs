public class Solution
{
    public Node CopyRandomList(Node head)
    {
        Dictionary<Node, Node> m = new Dictionary<Node, Node>();
        return DFS(head, m);
    }

    private Node DFS(Node head, Dictionary<Node, Node> m)
    {
        if (head == null)
            return null;
        if (m.ContainsKey(head))
            return m[head];

        Node node = new Node(head.val);
        m[head] = node;
        node.next = DFS(head.next, m);
        node.random = DFS(head.random, m);
        return node;
    }
}
