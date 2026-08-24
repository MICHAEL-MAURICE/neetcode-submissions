public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        Dictionary<int,int>dic=new();
        dic[0]=-1;
        int sum =0;
        for(int i=0;i<nums.Length;i++){
            sum+=nums[i];
            int rem=sum % k;
            if(!dic.ContainsKey(rem)){
                dic[rem]=i;
            }
            else if( i - dic[rem] > 1){
                return true;
            }

        }
        return false;
    }
}