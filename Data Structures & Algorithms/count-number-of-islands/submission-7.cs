public class Solution {
    private int [][] direction= new int[][]{
      new int[]{1,0},new int[]{-1,0},
      new int[]{0,1},new int[]{0,-1}  
    };
    private char [][]grid;
    public int NumIslands(char[][] grid) {
        this.grid=grid;
        int numberOfIsland=0;
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[0].Length;j++){
                if(grid[i][j]=='1'){
                    Bfs(i,j);
                    numberOfIsland++;
                }
            }
        }
return numberOfIsland;
    }


    private void Bfs(int i,int j){
        Queue<(int r,int c)> qu=new();
        grid[i][j]='0';
        qu.Enqueue((i,j));

        while(qu.Count>0){
            var (r,c)=qu.Dequeue();
            foreach(var dir in direction){
                int newr= r+dir[0];
                int newc= c+dir[1];
                if(newr>=0 && newc>=0 && newr<grid.Length && newc<grid[0].Length && grid[newr][newc]=='1'){
                     qu.Enqueue((newr,newc));
                     grid[newr][newc]='0';
                }
            }
            
        }
    }
}
