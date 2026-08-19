public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int>map= new Dictionary<int,int>();
        foreach(var val in nums){
            if(!map.ContainsKey(val)){
                map[val]=1;
            }
            map[val]++;
        }

        return map.OrderByDescending(x=>x.Value).Take(k).Select(x=>x.Key).ToArray();
    }
}
