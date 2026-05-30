public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length==0) return 0;
        HashSet<int> cons= new HashSet<int>();
        int count=1;
        int maxCount=1;
        foreach(var num in nums){
            cons.Add(num);
        }
        var list = cons.ToList();
list.Sort();
for (int i = 1; i < list.Count; i++)
{
   if(list[i]-list[i-1]==1){
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
