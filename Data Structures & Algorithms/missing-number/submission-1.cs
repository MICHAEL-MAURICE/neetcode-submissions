public class Solution {
    public int MissingNumber(int[] nums) {
        int n= nums.Length;
        int counter=0;
        Array.Sort(nums);
        foreach(var num in  nums){
            if(num==counter){
                counter++;
            }
            else return counter;
        }
         return counter;
    }
}
