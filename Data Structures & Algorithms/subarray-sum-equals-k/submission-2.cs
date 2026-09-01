public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int res=0, currsum=0;
        Dictionary<int,int>PreSum=new();
        PreSum[0]=1;
        foreach(var num in nums){
            currsum+=num;
            var diff= currsum-k;
            if(PreSum.ContainsKey(diff)){
               res+=PreSum[diff];
            }
            if(!PreSum.ContainsKey(currsum)){
                PreSum[currsum]=0;
            }
            PreSum[currsum]++;
        }

        return res;
    }
}