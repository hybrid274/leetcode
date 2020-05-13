public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (numRows == 0)
            return result;
        result.Add(new List<int>() { 1 });
        for (int i = 1; i < numRows; i++)
        {
            List<int> oneResult = new List<int>() { 1 };
            var preResult = result.Last();
            for (int j = 0; j < preResult.Count - 1; j++)
                oneResult.Add(preResult[j] + preResult[j + 1]);
            oneResult.Add(1);
            result.Add(oneResult);
        }
        return result;
    }
}
