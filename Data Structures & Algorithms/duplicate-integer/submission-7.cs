public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int,int>counted= new Dictionary<int,int>();
        foreach(var num in nums){
            if(!counted.ContainsKey(num)){
                counted[num]=0;

            }
            else
            return true;
        }
        return false;
    }
}