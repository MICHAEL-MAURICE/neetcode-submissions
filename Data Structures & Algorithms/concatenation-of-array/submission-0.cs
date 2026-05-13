public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int len=nums.Length;
        int[] newarr=new int [2*len];
        for(int i=0;i<2*len;i++){
            newarr[i]=nums[i%len];
        }
    return newarr;
    }
}