public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        int sum=0; int len=0;
        for(int i=0;i<nums.Length;i++){
            sum=0;
            len=0;
            for(int j=i;j<nums.Length;j++){
                   sum+=nums[j];
                   len++;
                   if((sum==k || sum%k==0) && len>1){
                    return true;
                   }
            }
        }

        return false;
    }
}