public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums.Length<=0)return false;
        var arrayNumbers=new HashSet<int>();
        foreach(var num in nums){
            if(!arrayNumbers.Add(num))return true;
        }
        return false;
    }
}