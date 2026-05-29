
public class Solution {
    public bool hasDuplicate(int[] nums) {
      Dictionary<int,int> countSum=new Dictionary<int,int>();
      foreach(var num in nums){
        if(!countSum.ContainsKey(num)){
            countSum[num]=1;
        }
        else{   
            return true;
        }

      }

      return false;
    }
}
