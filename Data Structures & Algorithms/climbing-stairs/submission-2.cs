public class Solution {
    private int?[]memo;
    public int ClimbStairs(int n) {     
        this.memo=new int?[n+1];

        return solve(n);
    }


    private int solve(int n){
        if(n<=1)return 1;
        if(memo[n]!=null)return memo[n].Value;

        memo[n]=solve(n-1)+solve(n-2);

        return memo[n].Value;
    }
}
