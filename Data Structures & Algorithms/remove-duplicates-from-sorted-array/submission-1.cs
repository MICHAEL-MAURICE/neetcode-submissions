public class Solution {
    public int RemoveDuplicates(int[] nums) {
        HashSet<int> arr= new HashSet<int>(nums);

        int i=0;
         foreach(var num in  arr){
          nums[i]=num;
          i++;
         }
      
    return arr.Count;
  
    }
}