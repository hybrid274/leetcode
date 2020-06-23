public class Solution
{
    public void Solve(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if ((i == 0 || i == board.Length - 1 || j == 0 || j == board[i].Length - 1) && board[i][j] == 'O')
                    DFS(board, i, j);
            }
        }
        for (int i = 0; i < board.Length; i++)
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == 'O')
                    board[i][j] = 'X';
                if (board[i][j] == '$')
                    board[i][j] = 'O';
            }
    }

    private static void DFS(char[][] board, int i, int j)
    {
        if (board[i][j] == 'O')
            board[i][j] = '$';
        if (i > 0 && board[i - 1][j] == 'O')
            DFS(board, i - 1, j);
        if (i < board.Length - 1 && board[i + 1][j] == 'O')
            DFS(board, i + 1, j);
        if (j > 0 && board[i][j - 1] == 'O')
            DFS(board, i, j - 1);
        if (j < board[i].Length - 1 && board[i][j + 1] == 'O')
            DFS(board, i, j + 1);
    }
}
