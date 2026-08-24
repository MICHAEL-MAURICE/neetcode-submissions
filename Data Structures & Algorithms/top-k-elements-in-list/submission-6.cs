public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
          Dictionary<int,int> count= new Dictionary<int,int>();
        foreach(var num in nums){
            if(count.ContainsKey(num)){
                count[num]++;
            }
            else{
                count[num]=1;
            }
        }

        var pqueue= new PriorityQueue<int,int>();
        foreach(var m  in count){
            pqueue.Enqueue(m.Key,m.Value);
            if(pqueue.Count>k){
                pqueue.Dequeue();
            }
        }

        int []res= new int[k];
        for(int i=0;i<k;i++){
            res[i]=pqueue.Dequeue();
        }

        return res;
    }
}
