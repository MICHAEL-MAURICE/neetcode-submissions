public class Solution {
    public void SortColors(int[] nums) {
        int zero=0; int ones=0; int twos=0;

        foreach (var num in nums){
            if(num==0)zero++;
            else if (num==1) ones++;
            else twos++;
        }
        int  i=0;
        while(i<zero){
            nums[i]=0;
            i++;
        }
        i=zero;
         while(i<zero+ones){
            nums[i]=1;
            i++;
        }
        i=zero+ones;
         while( i<nums.Length){
            nums[i]=2;
            i++;
        }
    }
}