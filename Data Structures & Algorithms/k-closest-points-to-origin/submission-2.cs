public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[],int> pq=new();
        foreach(var point in points){
   int length= ((point[0]*point[0])+(point[1]*point[1]));
      pq.Enqueue([point[0],point[1]],length);
        }
   int [][] result= new int [k][];

   for(int i=0;i<k;i++){
   
    var point = pq.Dequeue();
  result[i]= point;
   
   }
   return result;


    }
}
