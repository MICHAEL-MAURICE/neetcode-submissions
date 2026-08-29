public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int>dic=new();
       int []res= new int[k];
        PriorityQueue<int,int>pq=new();
        foreach(var num in nums){
            if(dic.ContainsKey(num)){
                dic[num]++;
            }
            else{
                dic[num]=1;
            }
        }

         foreach(var pair in dic){
            pq.Enqueue(pair.Key,pair.Value);
            if(pq.Count>k){
                pq.Dequeue();
            }
         }
         
          
        for(int i=0;i<k;i++){
            res[i]=pq.Dequeue();
        }

        return res; 
       
    }
}
