public class Solution {
    private char[][]grid;
    public int NumIslands(char[][] grid) {
        this.grid=grid;
        int counter=0;
        for(int i=0;i<grid.Length;i++){
            for(int  j=0;j<grid[0].Length;j++){
                if(grid[i][j]=='1'){
                 dfs(i,j);
                 counter++;
                }
            }
        }
        return counter;
    }
   private void dfs(int i, int j){
 if(i<0 || i>=grid.Length || j<0 || j>=grid[0].Length || grid[i][j]=='0')return;
 grid[i][j]='0';
   dfs(i+1,j);
   dfs(i-1,j);
   dfs(i,j+1);
   dfs(i,j-1);
   }

}
