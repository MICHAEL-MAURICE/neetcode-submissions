public class Solution {
    public int MajorityElement(int[] nums) {
        int maj= nums.Length/2;
        Dictionary<int,int>res= new Dictionary<int,int>();

        foreach(var  num in  nums){
            if(!res.ContainsKey(num)){
                res[num]=1;
            }
            else {
                if(res[num]>maj) return num;
                res[num]++;
            }
        }

      foreach (var pair in res){
        if(pair.Value>maj) return pair.Key;
      }

         return -1;
    }
}