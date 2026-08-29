public class Solution {
    private string s;
    private HashSet<string>words;
    private bool ?[]memo; 
    public bool WordBreak(string s, List<string> wordDict) {
        this.s=s;
        this.words=new HashSet<string>(wordDict);
        this.memo=new bool? [s.Length];
        return solve(0);
    }

    private bool solve(int i){
        if(i==s.Length){
            return true;
        }

        if(memo[i]!=null)return memo[i].Value;

        for(int j=i+1;j<=s.Length;j++){
            string substring=s.Substring(i,j-i);
            if(words.Contains(substring) && solve(j)){
                memo[i]=true;
                return true;
            }
        }
memo[i]=false;
return false;
    }
}
