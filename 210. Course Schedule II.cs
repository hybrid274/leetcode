public class Solution
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        IList<List<int>> graph = new List<List<int>>();
        int[] visited = new int[numCourses];
        List<int> result = new List<int>();
        for (int i = 0; i < numCourses; i++)
            graph.Add(new List<int>());
        foreach (var p in prerequisites)
            graph[p[0]].Add(p[1]);
        for (int i = 0; i < numCourses; i++)
        {
            if (DFS(graph, visited, i, result))
                return new int[0];
        }
        return result.ToArray();
    }

    private bool DFS(IList<List<int>> graph, int[] visited, int index, List<int> result)
    {
        if (visited[index] == 1)
            return true;
        if (visited[index] == 2)
            return false;
        visited[index] = 1;
        foreach (var item in graph[index])
        {
            if (DFS(graph, visited, item, result))
                return false;
        }
        visited[index] = 2;
        result.Add(index);
        return false;
    }
}
