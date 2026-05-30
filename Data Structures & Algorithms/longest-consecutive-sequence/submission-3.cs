public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0) return 0;
     
        int count=1;
        int maxCount=1;
       
Array.Sort(nums);
for (int i = 1; i < nums.Length; i++)
{
    if(nums[i]==nums[i-1]) continue;
   if(nums[i]-nums[i-1]==1){
    count++;
    maxCount=Math.Max(count,maxCount);
   }
   else{
    count=1;
   }
}

return maxCount;
       
    }
}
