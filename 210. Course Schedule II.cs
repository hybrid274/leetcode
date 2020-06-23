using System;
using System.Collections.Generic;

public class Solution
{
    public int[] FindOrder(int numCourses, int[][] prerequisites)
    {
        List<int>[] graph = new List<int>[numCourses];
        for (int i = 0; i < numCourses; i++)
            graph[i] = new List<int>();
        foreach (var item in prerequisites)
            graph[item[1]].Add(item[0]);
        int[] visited = new int[numCourses];
        Stack<int> path = new Stack<int>();
        for (int i = 0; i < numCourses; i++)
        {
            if (!DFS(graph, visited, i, path))
                return new int[0];
        }
        return path.ToArray();
    }

    private bool DFS(List<int>[] graph, int[] visited, int i, Stack<int> path)
    {
        if (visited[i] == 1) return false;
        if (visited[i] == 2) return true;
        visited[i] = 1;

        foreach (var item in graph[i])
        {
            if (!DFS(graph, visited, item, path))
                return false;
        }
        visited[i] = 2;
        path.Push(i);
        return true;
    }
}
