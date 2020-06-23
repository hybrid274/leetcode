public class Solution
{
    public int NumIslands(char[][] grid)
    {
        int res = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    res++;
                    DFS(grid, i, j);
                }
            }
        }
        return res;
    }

    private void DFS(char[][] grid, int i, int j)
    {
        if (grid[i][j] == '1')
            grid[i][j] = '$';
        if (i > 0 && grid[i - 1][j] == '1')
            DFS(grid, i - 1, j);
        if (j > 0 && grid[i][j - 1] == '1')
            DFS(grid, i, j - 1);
        if (i < grid.Length - 1 && grid[i + 1][j] == '1')
            DFS(grid, i + 1, j);
        if (j < grid[i].Length - 1 && grid[i][j + 1] == '1')
            DFS(grid, i, j + 1);
    }
}
