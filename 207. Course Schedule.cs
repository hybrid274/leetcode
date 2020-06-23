public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        List<List<int>> adj = new List<List<int>>();
        List<int> visited = new List<int>();
        for (int i = 0; i < numCourses; i++)
        {
            adj.Add(new List<int>());
            visited.Add(0);
        }

        foreach (var item in prerequisites)
        {
            adj[item[1]].Add(item[0]);
        }
        for (int i = 0; i < numCourses; i++)
        {
            if (IsCyclic(adj, visited, i))
                return false;
        }
        return true;
    }

    private bool IsCyclic(List<List<int>> adj, List<int> visited, int curNode)
    {
        if (visited[curNode] == 2)
            return true;
        visited[curNode] = 2;
        foreach (var item in adj[curNode])
        {
            if (visited[curNode] != 1)
                if (IsCyclic(adj, visited, item))
                    return true;
        }
        visited[curNode] = 1;
        return false;
    }
}
