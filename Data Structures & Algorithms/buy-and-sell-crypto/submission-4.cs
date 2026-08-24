public class Solution {
    public int MaxProfit(int[] prices) {
        int res=0;
        int i=0;
        int j=i+1;

        while(j<prices.Length){
            if(prices[i]>=prices[j]){
             i=j;
             j=i+1;
            }
            else{
                res=Math.Max(res,prices[j]-prices[i]);
                j++;
            }

        }

        return res;
    }
}

