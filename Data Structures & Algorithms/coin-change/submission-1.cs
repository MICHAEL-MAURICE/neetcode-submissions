public class Solution {
    private int[]coins;
    private int INF;
    private int?[,]dp;
    public int CoinChange(int[] coins, int amount) {
        this.coins=coins;
        this.INF=amount+1;
        this.dp = new int?[coins.Length,amount+1];

        var answer= solve(coins.Length-1,amount);

        return answer>=INF ?-1:answer;
    }


    private int solve(int idx, int amount){
        if(amount==0)return 0;
        if(idx<0 || amount<0)return INF;

        if(dp[idx,amount]!=null)return dp[idx,amount].Value;

        int take = solve(idx,amount-coins[idx])+1;
        int leave= solve(idx-1,amount);

        dp[idx,amount]=Math.Min(take,leave);

        return dp[idx,amount].Value;
    }
}
