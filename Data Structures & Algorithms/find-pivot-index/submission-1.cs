public class Solution {
    public int PivotIndex(int[] nums) {
        int total=0;
        foreach(var num in  nums){
            total +=num;
        }
        int leftsum=0;
        int rightsum=0;

        for(int i=0;i<nums.Length;i++){
            rightsum= total- nums[i]-leftsum;
            if(leftsum==rightsum) return i;
            leftsum+=nums[i];
        }
        return -1;

    }
}