public class Solution {    
    public int OrangesRotting(int[][] grid) {
         int fresh=0;
         Queue<(int r,int c)>queue=new();
         int minutes=0;

         int [][] direction= new int[][]{
            new int[]{1,0},new int[]{-1,0} , 
            new int []{0,1} , new int[]{0,-1}
         };
         for(int i=0;i<grid.Length;i++){
         for(int j=0;j<grid[0].Length;j++){
            if(grid[i][j]==1)fresh++;
            if(grid[i][j]==2)queue.Enqueue((i,j));
         }
         }

      while(fresh> 0 && queue.Count>0){
        var size= queue.Count;
        minutes++;
        for(int i=0;i<size;i++){
          var (r,c)=queue.Dequeue();
          foreach(var dir in direction ){

            var newr= r + dir[0];
            var newc= c + dir[1];

    if(newr>=0 && newr<grid.Length && newc>=0 && newc<grid[0].Length && grid[newr][newc]==1){
                        grid[newr][newc]=2;
                        fresh--;
                        queue.Enqueue((newr,newc));
                    }
          }



        }
      }
if(fresh==0) return minutes;
return -1;

    }
}
