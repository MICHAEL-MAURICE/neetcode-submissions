public class Solution {
    public int[] TwoSum(int[] nums, int target) {
          Dictionary<int,int>sumIndx=new();
          for(int i=0;i<nums.Length;i++){
            int mud= target-nums[i];
            if(sumIndx.ContainsKey(mud)){
                return[sumIndx[mud],i];
            }
            sumIndx[nums[i]]=i;
          }

          return [-1,-1];
    }
}
