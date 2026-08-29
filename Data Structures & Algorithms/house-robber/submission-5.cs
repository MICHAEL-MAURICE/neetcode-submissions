public class Solution {
    private int?[]memo;
    private int[]cost;
    public int Rob(int[] nums) {
        this.memo=new int?[nums.Length];
        this.cost=nums;
       return solve(0);
    }
    private int solve(int i){
        if(i>=cost.Length){
            return 0;
        }
        if(memo[i]!=null) return memo[i].Value;

        int take= solve(i+2)+cost[i];
        int leave= solve(i+1);
         memo[i]=Math.Max(take,leave);

         return memo[i].Value;

    }
    
}
