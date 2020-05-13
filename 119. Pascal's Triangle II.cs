public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        int[] res = new int[rowIndex + 1];
        res[0] = 1;

        for (int i = 1; i <= rowIndex; i++)
            for (int j = i; j > 0; j--)
                res[j] += res[j - 1];

        return res;
    }
}
