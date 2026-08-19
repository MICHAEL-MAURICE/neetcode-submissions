public class Solution {
    private int [][]grid;
    private int? [,]memo;
    public int MinPathSum(int[][] grid) {
        this.grid=grid;
        this.memo= new int?[grid.Length,grid[0].Length];

        return solve(0,0);

    }

    private int solve(int i,int j){
        if(i>=grid.Length || j>= grid[0].Length) return int.MaxValue;

        if(i==grid.Length-1 && j== grid[0].Length-1) return grid[i][j];

       if(memo[i,j]!=null)return memo[i,j].Value;

       int op1=solve(i+1,j);
       int  op2= solve(i,j+1);

       memo[i,j]=Math.Min(op1,op2)+grid[i][j];

       return memo[i,j].Value;

    }


}