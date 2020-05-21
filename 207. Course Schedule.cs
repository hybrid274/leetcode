public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        List<List<int>> map = new List<List<int>>();
        int[] visit = new int[numCourses];
        for (int i = 0; i < numCourses; i++)
            map.Add(new List<int>());
        foreach (int[] j in prerequisites)
            map[j[1]].Add(j[0]);
        for (int i = 0; i < numCourses; i++)
        {
            if (IsCircle(visit, map, i))
                return false;
        }
        return true;
    }

    private bool IsCircle(int[] visit, List<List<int>> map, int index)
    {
        if (visit[index] == 1)
            return true;
        if (visit[index] == 2)
            return false;
        visit[index] = 1;
        foreach (int i in map[index])
            if (IsCircle(visit, map, i))
                return true;
        visit[index] = 2;
        return false;
    }
}
