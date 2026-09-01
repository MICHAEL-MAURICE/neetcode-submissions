public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int>res=new();
        Dictionary<int,int>count=new();
        PriorityQueue<int,int>pq=new();

        foreach(var num in nums){
            if(count.ContainsKey(num))
             count[num]++;
             else{
                count[num]=1;
             }
        }
        foreach(var pair in count){
            pq.Enqueue(pair.Key,-pair.Value);
        }
        while(pq.Count>0&& k>0){
            res.Add(pq.Dequeue());
            k--;
        }

        return res.ToArray();
    }
}
