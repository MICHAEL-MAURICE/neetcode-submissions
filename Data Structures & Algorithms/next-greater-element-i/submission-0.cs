public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        
        int []ans= new int [nums1.Length];
        for(int i=0;i<nums1.Length;i++){
            bool found=false;
            for(int j=0;j<nums2.Length;j++){
                if(nums1[i]==nums2[j]){
                    found=true;
                }
                if(found && nums2[j]>nums1[i]){
                    ans[i]=nums2[j];
                    break;
                }
            }
            if(ans[i]==0){
                ans[i]=-1;
            }
        }
return ans;
    }
}