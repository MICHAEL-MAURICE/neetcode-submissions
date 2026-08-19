public class Solution {
    private string s;
    private bool?[]memo;
    private HashSet<string>words;
    public bool WordBreak(string s, List<string> wordDict) {
        this.s=s;
        this.words=new HashSet<string>(wordDict);
        this.memo= new bool?[s.Length];

        return solve(0);
    }

    private bool solve(int start){
        if(start==s.Length) return true;
        if(memo[start]!=null) return memo[start].Value;

        for(int end= start+1;end <= s.Length;end++){
            var substring= s.Substring(start,end-start);
            if(words.Contains(substring)){
                if(solve(end)==true){
                    memo[start]=true;
                    return true;
                }
            }
        }
        memo[start]=false;
        return false;
    }
}
