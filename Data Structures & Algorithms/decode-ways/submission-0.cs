public class Solution {
    private string s;
    private int?[]dp;
    public int NumDecodings(string s) {
        this.s=s;
        this.dp=new int?[s.Length];

        return solve(0);
    }

    private int solve(int idx){

if (idx==s.Length) return 1;
if(s[idx]=='0') return 0;
if(dp[idx]!=null) return dp[idx].Value;

//take one 
int  ways= solve(idx+1);

if(idx+1<s.Length){
 
 int  number = (s[idx]-'0')*10 +(s[idx+1]-'0');

 if(number >9 &&number<27) {
    ways+=solve(idx+2);
 }
}
dp[idx]=ways;

return ways;

    }
}
