public class Solution
{
    public IList<IList<int>> CombinationSum3(int k, int n)
    {
        List<IList<int>> result = new List<IList<int>>();
        DFS(k, n, 1, new List<int>(), result);
        return result;
    }

    private void DFS(int k, int n, int start, List<int> list, List<IList<int>> result)
    {
        if (n < 0)
            return;
        if (n == 0 && k == 0)
            result.Add(new List<int>(list));
        else
        {
            for (int i = start; i < 10; i++)
            {
                list.Add(i);
                DFS(k - 1, n - i, i + 1, list, result);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
