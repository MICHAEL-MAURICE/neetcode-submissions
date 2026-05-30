public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int mult=1;
        List<int>retur=new List<int>();
        for(int i=0;i<nums.Length;i++){
            mult=1;
            for(int j=0;j<nums.Length;j++){
                if(i!=j){
                    mult*=nums[j];
                }

            }
            retur.Add(mult);
        }
        
return retur.ToArray();
    }
}
