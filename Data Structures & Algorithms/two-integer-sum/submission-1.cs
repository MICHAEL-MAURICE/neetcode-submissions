public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int>sum= new Dictionary<int,int>();
         for(int i=0;i<nums.Length;i++){
            int mub= target- nums[i];
            if(sum.ContainsKey(mub)){
                return new [] {sum[mub],i};
            }
            sum[nums[i]]=i;
         }
         return new []{-1,-1};
    }
}
