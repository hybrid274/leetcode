public class Solution
{
    Dictionary<Node, Node> map = new Dictionary<Node, Node>();
    public Node CloneGraph(Node node)
    {
        if (node == null)
            return null;

        if (!map.ContainsKey(node))
        {
            map[node] = new Node(node.val, new List<Node>());
            foreach (var neighbor in node.neighbors)
                map[node].neighbors.Add(CloneGraph(neighbor));
        }
        return map[node];
    }
}
