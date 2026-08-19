public class Solution {
    private HashSet<string>words;
    private bool?[]memo;
    private string s;
    public bool WordBreak(string s, List<string> wordDict) {
        this.words=new HashSet<string>(wordDict);
        this .s=s;
        this .memo= new bool?[s.Length];
        return dfs(0);
    }

    private bool dfs(int start){
        if(start==s.Length){
            return true;
        }
        if(memo[start]!=null) return memo[start].Value;

        for(int end= start+1;end<=s.Length;end++){
            var substr= s.Substring(start,end-start);
            if(words.Contains(substr)){
                if(dfs(end)){
                memo[start]=true;
                return true;
                }
                
            }
        }

        memo[start]=false;
        return false;
    }
}
