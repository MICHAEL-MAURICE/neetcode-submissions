public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    Dictionary<int,int>sum=new Dictionary<int,int>();
    for(int i=0;i<nums.Length;i++){
        var rem= target-nums[i];
        if(sum.ContainsKey(rem)){
            return [sum[rem],i];
        }
        sum[nums[i]]=i;
    }

    return  [-1,-1];
    }
}
