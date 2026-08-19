public class Solution {

    private int[]nums;
    private bool? [,] memo;
    private int target;
    public bool CanPartition(int[] nums) {
        this.nums=nums;
        int sum=0;
        foreach(var s in nums)sum+=s;
        if (sum % 2 != 0)
            return false;
         target= sum/2;
        memo=new bool?[nums.Length,target+1];
       
return solve(nums.Length-1,target);

    }

    private bool solve(int idx, int target){
  if  (target==0)return true;
  if(idx<0 || target<0) return false;
  if(memo[idx,target]!=null)return memo[idx,target].Value;

  var take =solve(idx-1,target-nums[idx]);
  var leave= solve(idx-1,target);

  memo[idx,target]=take ||leave;

  return memo[idx,target].Value;

    }
}