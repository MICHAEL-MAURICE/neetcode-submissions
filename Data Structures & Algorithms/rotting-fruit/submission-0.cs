public class Solution {
    public int OrangesRotting(int[][] grid) {
        Queue<(int r,int c)>queue=new();
        int minitues=0;
        int freshers=0;
        int[][] directions={
            new int[]{1,0},
            new int[]{-1,0},
            new int[]{0,1},
            new int[]{0,-1}
        };

        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[0].Length;j++){
                if(grid[i][j]==1){
                    freshers++;
                }
                if(grid[i][j]==2){
                    queue.Enqueue((i,j));
                }
            }
        }

       while(queue.Count>0 && freshers>0){
       
        int size= queue.Count;
        for(int i=0;i<size;i++){
          var (r,c)=queue.Dequeue();
          foreach(var dir in directions){
            int newrow= r+dir[0];
            int newcol=c+dir[1];

            if(newrow>=0 && newrow < grid.Length && newcol>=0 && newcol<grid[0].Length &&   grid[newrow][newcol]==1 ){
                grid[newrow][newcol]=2;
                freshers--;
                queue.Enqueue((newrow, newcol));
            }
          }
        }
       minitues++;
       }


 if(freshers==0)
 return minitues;
 
 return -1;

    }
}
