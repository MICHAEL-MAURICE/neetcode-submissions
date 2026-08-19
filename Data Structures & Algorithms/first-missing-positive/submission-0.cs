public class Solution {
    public int FirstMissingPositive(int[] nums) {
        int missed=1;
        while(true){
        bool isFound=false;
        foreach(var n in nums){
            if(missed==n){
                isFound=true;
                break;
            }
        }
         if(!isFound) return missed;

         missed++;

        }
        return missed;
    }
}