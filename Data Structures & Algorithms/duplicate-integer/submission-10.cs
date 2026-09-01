public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int>count= new HashSet<int>();
        foreach(var num in nums){
            if(count.Contains(num)) return true;
            count.Add(num);
        }
        return false;
    }
}