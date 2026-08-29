public class Solution {
    private int?[]memo;
    public int ClimbStairs(int n) {     
       this.memo=new int?[n+3];

        return solve(n);

    }

    private int solve(int num){
        if(num<=1) return 1;

        if(memo[num]!=null) return memo[num].Value;

         memo[num]= solve(num-1)+solve(num-2);
         return memo[num].Value;
    }
}
