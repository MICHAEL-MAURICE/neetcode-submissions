public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int>numSet= new HashSet<int>(nums);
        int longest=0;
        foreach(var n in nums){
            if(!numSet.Contains(n-1)){
                int len=1;
                while(numSet.Contains(n+len)){
                    len++;
                }
                longest=Math.Max(longest,len);
            }
        }

        return longest;
    }
}
