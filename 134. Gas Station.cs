public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int total = 0;
        int sum = 0;
        int start = 0;
        for (int i = 0; i < gas.Length; i++)
        {
            int part = gas[i] - cost[i];;
            total += part;
            sum += part;
            if (sum < 0)
            {
                start = i + 1;
                sum = 0;
            }
        }
        return total < 0 ? -1 : start;
    }
}
