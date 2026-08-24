public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int,int>prefix= new();
        int res=0;
        int cur=0;
         prefix[0] = 1;
         foreach(var num in  nums){
            cur+=num;
            var diff= cur-k;
            if(prefix.ContainsKey(diff)){
                res+=prefix[diff];
            }
            if(!prefix.ContainsKey(cur)){
                prefix[cur]=0;
            }
            prefix[cur]++;
         }

         return res;
    }
}