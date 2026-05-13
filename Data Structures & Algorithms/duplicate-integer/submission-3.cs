
public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int>uniqenumbers=new HashSet<int>();
        foreach(var num in nums ){
            if(uniqenumbers.Contains(num)) return true;
           uniqenumbers.Add(num);
        }
        return false;
    }
}
