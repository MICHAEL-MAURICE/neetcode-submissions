public class Solution {
    public bool hasDuplicate(int[] nums) {
        var arrayNumbers=new HashSet<int>();
        foreach(var num in nums){
            if(arrayNumbers.Contains(num))return true;
            arrayNumbers.Add(num);
        }
        return false;
    }
}