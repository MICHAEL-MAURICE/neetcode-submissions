public class Solution {
    private string s;
    private HashSet<string>words;
    private bool? [] memo;
    public bool WordBreak(string s, List<string> wordDict) {
        this.s=s;
        words= new HashSet<string>(wordDict);
        memo=new bool?[s.Length];

return solve(0);
    }
    private bool solve(int start){
        if(start== s.Length) return true;

        if(memo[start]!=null)return memo[start].Value;

        for(int end= start+1; end<=s.Length;end++){
            string substr= s.Substring(start,end-start);
            if(words.Contains(substr)){
                if(solve(end)){
                    memo[start]=true;
                    return true;
                }

            }
        }

        memo[start]=false;
        return false;


    }
}
