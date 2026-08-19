public class Solution {
    private int m;
    private int n;
    private int ?[,]memo;
    public int UniquePaths(int m, int n) {
        this.m=m;
        this.n=n;
        this.memo=new int?[m,n];
        return solve(0,0);
    }
    private int solve(int i,int j){
        if(i>=m-1 || j>=n-1) return 1;

        if(memo[i,j]!=null) return memo[i,j].Value;

        int option1= solve(i+1,j);
        int option2= solve(i,j+1);

        memo[i,j]=option1+option2;

        return memo[i,j].Value;
    }
}
