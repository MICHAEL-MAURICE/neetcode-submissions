public class Solution {
      public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++) {
            int currPrice = prices[i];
            minPrice = Math.Min(minPrice, currPrice);      // Update min price seen so far
            maxProfit = Math.Max(maxProfit, currPrice - minPrice);  // Check profit if sold today
        }
        return maxProfit;
    }
}

