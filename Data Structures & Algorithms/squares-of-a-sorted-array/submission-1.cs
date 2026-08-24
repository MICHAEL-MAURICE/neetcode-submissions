public class Solution {
    public int[] SortedSquares(int[] nums) {
        int left=0;
        int [] res = new int[nums.Length];
        int right=nums.Length-1;
        for(int i=nums.Length-1;i>=0;i--){
            var rightsquar= nums[right]*nums[right];
            var leftsquar= nums[left]* nums[left];
            if(rightsquar>leftsquar){
               res[i]=rightsquar;
               right--;
            }
             else {
               res[i]=leftsquar;
               left++;
             }


        }
        return res;
    }
}