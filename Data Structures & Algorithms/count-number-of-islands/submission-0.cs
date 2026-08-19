public class Solution {
    private char [][] grid;
    public int NumIslands(char[][] grid) {
        int numberOfIsland=0;
        this .grid=grid;
        for(int i=0;i<grid.Length;i++){
            for(int j=0;j<grid[i].Length;j++){
             if(grid[i][j]=='1'){
                  numberOfIsland++;
                  Dfs(i,j);
             }

            }
        }

        return numberOfIsland;
    }
private void Dfs(int i,int j){
    if(i<0||i>=grid.Length||j<0 || j>=grid[0].Length||grid[i][j]=='0' )return;

    grid[i][j]='0';

    Dfs(i+1,j);
    Dfs(i-1,j);
    Dfs(i,j+1);
    Dfs(i,j-1);
}

}
