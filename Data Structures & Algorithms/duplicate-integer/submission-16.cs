public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int>found=new();
        foreach(var num in nums){
            if(!found.Add(num))return true;
        }

        return false;
    }
}