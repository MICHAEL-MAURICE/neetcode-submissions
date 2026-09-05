public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int>frequent=new();
        PriorityQueue<int,int>pq=new();
        foreach(var num in nums){
            if(frequent.ContainsKey(num)){
                frequent[num]++;
            }
            else
            frequent[num]=1;
        }

        foreach(var frq in frequent ){
            pq.Enqueue(frq.Key,-frq.Value);
        }

int [] res=new int[k];
for(int i=0;i<k;i++){
    res[i]=pq.Dequeue();
}
return res;

    }
}
