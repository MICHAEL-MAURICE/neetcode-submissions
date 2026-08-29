public class Solution {
    private int[]nums;
    private bool?[,]dp;
    private int target;
    public bool CanPartition(int[] nums) {
        this.nums=nums;
        var sum= nums.Sum();
        if(sum%2!=0)return false;
        target=sum/2;
        dp= new bool?[nums.Length,target+1];

       return solve(nums.Length-1,target);
    }
    private bool solve(int idx,int amount){
        if(idx<0 ||amount<0) return false;
        if(amount==0) return true;
        if(dp[idx,amount]!=null)return dp[idx,amount].Value;
       var take=solve(idx-1,amount-nums[idx]);
       var leave= solve(idx-1,amount);

       dp[idx,amount]=take|| leave;
       return dp[idx,amount].Value;

    }
}
