public class Solution
{
    public Node CloneGraph(Node node)
    {
        var m = new Dictionary<Node, Node>();
        return DFS(node, m);
    }

    private Node DFS(Node node, Dictionary<Node, Node> m)
    {
        if (node == null)
            return null;
        if (m.ContainsKey(node))
            return m[node];
        Node clone = new Node(node.val);
        m[node] = clone;
        foreach (var n in node.neighbors)
            clone.neighbors.Add(DFS(n, m));
        return clone;
    }
}
