public class Solution {
    public int MaxSubArray(int[] nums) {
       // int i=0;
        int j=0;
        int maxsum=-10001;
        int sum=0;
        while(j<nums.Length){
            if(sum<0){
                Console.WriteLine(sum);
         //      i=j; 
                sum=0; 
            } 
            
                sum+=nums[j];
                j++;
            
            maxsum= Math.Max(maxsum,sum);

        }

        return maxsum;
    }
}
