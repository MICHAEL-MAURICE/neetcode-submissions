public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue <int,int>pq=new();
        foreach(var num in nums){
            pq.Enqueue(num,num);
        }

        while(pq.Count>k){
            pq.Dequeue();
        }

        return pq.Peek();
    }
}
