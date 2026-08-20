public class Solution {
    public int LongestConsecutive(int[] nums) {
        int longest=0;
        HashSet<int>counter= new HashSet<int>(nums);

        foreach(var num in nums){
            int len=1;
            if(!counter.Contains(num-1)){
               while(counter.Contains(num+len)){
                len++;
               }
            }
            longest=Math.Max(longest,len);
        }
        return longest;
    }
}
