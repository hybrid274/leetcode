public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int n = prices.Length;
        if (n == 0) return 0;
        int globalMaxProfit = 0;
        int globalMin = prices[0];
        for (int i = 1; i < n; i++)
        {
            int curPrice = prices[i];
            int localMaxProfit = Math.Max(0, curPrice - globalMin);
            globalMaxProfit = Math.Max(localMaxProfit, globalMaxProfit);
            globalMin = Math.Min(curPrice, globalMin);
        }
        return globalMaxProfit;
    }
}
