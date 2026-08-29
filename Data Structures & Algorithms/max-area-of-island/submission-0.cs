public class Solution {
    private int[][] grid;
    public int MaxAreaOfIsland(int[][] grid) {
        this.grid=grid;
        int island=0;
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[0].Length;j++){
               if(grid[i][j]==1){
               island=Math.Max( Dfs(i,j),island);
              
               }
            }
        }

        return island;
    }

     private int Dfs(int i, int j){

        if(i<0 || i>=grid.Length || j<0 || j>=grid[0].Length || grid[i][j]== 0) return 0;
        grid[i][j]=0;
int res=1;
      res+=Dfs(i+1,j);
      res+=Dfs(i-1,j);
       res+=Dfs(i,j+1);
       res+=Dfs(i,j-1);
return res;

    }
}
