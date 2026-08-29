public class Solution {
    private string s;
    private int?[]memo;
    public int NumDecodings(string s) {
        this.memo=new int?[s.Length];
        this.s=s;
       return solve(0);
    }

    private int solve(int idx){
        if(idx==s.Length)return 1;
        if(s[idx]=='0')return 0;
        if(memo[idx]!=null)return memo[idx].Value;

        var res=solve(idx+1);

        if(idx+1<s.Length){

            var number= (s[idx]-'0')*10+(s[idx+1]-'0');

            if(number>9 && number<27){
                res+=solve(idx+2);
            }
        }
        memo[idx]=res;

        return memo[idx].Value;
    }
}
