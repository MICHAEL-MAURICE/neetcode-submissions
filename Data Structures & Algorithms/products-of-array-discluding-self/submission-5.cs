public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int [] ans= new int [nums.Length];
        int countZeroes=0;
        int mul=1;

        foreach(var num in nums){
               if(num==0){
                countZeroes++;
               }    
               else{
                mul*=num;
               }
        }

        for(int i=0;i<nums.Length;i++){
            if((countZeroes==1 && nums[i]!=0) || countZeroes>1){
                ans[i]=0;
            }
            else if(nums[i]==0){
                ans[i]=mul;
            }
            else{
                ans[i]=(mul/nums[i]);
            }
        }

        return ans;
    }
}
