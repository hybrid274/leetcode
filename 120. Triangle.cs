public class Solution
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        for (int r = triangle.Count - 2; r >= 0; r--)
            for (int i = 0; i < triangle[r].Count; i++)
                triangle[r][i] += Math.Min(triangle[r + 1][i], triangle[r + 1][i + 1]);

        return triangle[0][0];
    }
}
