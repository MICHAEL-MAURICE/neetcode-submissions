public class Solution {

    int []dp= new int[46];

    public Solution(){
        Array.Fill(dp,-1);
    }
    public int ClimbStairs(int n) {     
        if(n<=1)return 1;
        if(dp[n]!=-1)return dp[n];

        dp[n]= ClimbStairs(n-1)+ClimbStairs(n-2);

        return dp[n];
    }
}
