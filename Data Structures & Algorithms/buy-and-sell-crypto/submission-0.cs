public class Solution {
    public int MaxProfit(int[] prices) {
        int l = 0, r = 1;
        var result = 0;

        while (r < prices.Length)
        {
            if (prices[l] < prices[r])
            {
                var profit = prices[r] - prices[l];
                result = Math.Max(result, profit);
            }
            else
            {
                l = r;
            }

            ++r;
        }

        return result;
    }
}
