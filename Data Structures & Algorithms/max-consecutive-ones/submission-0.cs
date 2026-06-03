public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int count=0;
        int maxons=0;
        foreach(var num in nums){
            if(num==1)count++;
            else {
                maxons=Math.Max(maxons,count);
                count=0;
            }
        }
        maxons=Math.Max(maxons,count);
        return maxons;
    }
}