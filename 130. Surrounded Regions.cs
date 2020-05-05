public class Solution
{
    public void Solve(char[][] board)
    {
        if (board.Length == 0 || board[0].Length == 0) { return; }
        FindBorderZeros(board);
        UpdateBoard(board);
    }

    private void UpdateBoard(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == 'O') { board[i][j] = 'X'; }
                else if (board[i][j] == 'Y') { board[i][j] = 'O'; }
            }
        }
    }

    private void FindBorderZeros(char[][] board)
    {
        for (int i = 1; i < board.Length - 1; i++)
        {
            if (board[i][0] == 'O') { Traverse(board, i, 0); }
            if (board[i][board[0].Length - 1] == 'O') { Traverse(board, i, board[0].Length - 1); }
        }

        for (int j = 0; j < board[0].Length; j++)
        {
            if (board[0][j] == 'O') { Traverse(board, 0, j); }
            if (board[board.Length - 1][j] == 'O') { Traverse(board, board.Length - 1, j); }
        }
    }

    private void Traverse(char[][] board, int i, int j)
    {
        if (board[i][j] != 'O') { return; }

        board[i][j] = 'Y';
        if (i > 1) { Traverse(board, i - 1, j); }
        if (j > 1) { Traverse(board, i, j - 1); }
        if (i < board.Length - 1) { Traverse(board, i + 1, j); }
        if (j < board[0].Length - 1) { Traverse(board, i, j + 1); }
    }
}
