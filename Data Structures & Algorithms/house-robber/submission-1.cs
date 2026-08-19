public class Solution {
    private int[]cost;
    private int?[] dp;
    public int Rob(int[] nums) {
        this.cost=nums;
        this.dp=new int?[nums.Length];
return solve(0);
    }

    private int solve (int i){
        if(i>=cost.Length) return 0;

        if(dp[i]!=null) return dp[i].Value;
        int  take = solve (i+2)+cost[i];
        int leave= solve(i+1);

        dp[i]= Math.Max(take,leave);
        return dp[i].Value;
    }
}
