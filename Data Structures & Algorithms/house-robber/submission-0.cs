public class Solution {
   private int [] cost;
   private int?[]dp;
    public int Rob(int[] nums) {
        this.cost=nums;
        this .dp=new int?[nums.Length];

        return solve (nums.Length-1);

    }

    public int solve(int n){
     if(n<0) return 0;

     if(dp[n]!=null) return dp[n].Value;

     int  take= solve(n-2)+cost[n];
     int leave= solve(n-1);


     dp[n]=Math.Max(take,leave);

     return dp[n].Value;


    }
}
