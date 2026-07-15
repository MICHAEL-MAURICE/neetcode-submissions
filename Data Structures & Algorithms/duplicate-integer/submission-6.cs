public class Solution {
    public bool hasDuplicate(int[] nums) {
       HashSet<int> dupli= new  HashSet<int>();

       foreach(var num in  nums){
        if(dupli.Contains(num)) return true;
        dupli.Add(num);
       }
       return false;
    }
}