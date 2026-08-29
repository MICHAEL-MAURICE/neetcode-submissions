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

        while(queue.Count>0 &&freshers >0 ){

            int size= queue.Count;
            for(int i=0;i<size;i++){
                var (r,c)= queue.Dequeue();

                foreach(var dir in directions){
                    var newr= r+dir[0];
                    var newc= c+dir[1];

                    if(newr>=0 && newr<grid.Length && newc>=0 && newc<grid[0].Length && grid[newr][newc]==1){
                        grid[newr][newc]=2;
                        freshers--;
                        queue.Enqueue((newr,newc));
                    }
                }
            }

            minitues++;
        }
          



if(freshers==0) return minitues;
return -1;

    }
}
