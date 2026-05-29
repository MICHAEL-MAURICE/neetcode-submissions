public class Solution {
    public int[] TwoSum(int[] nums, int target) {
      Dictionary<int,int>twosum=new Dictionary<int,int>();
for(int i=0; i<nums.Length; i++){
    var rem= target - nums[i];
    if(twosum.ContainsKey(rem)){
        return new int[] {twosum[rem], i};
    }
    else{
        twosum.Add(nums[i],i);
    }

}
return null;
    }
}
