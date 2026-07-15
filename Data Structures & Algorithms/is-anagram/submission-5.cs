public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length ) return false;
        int[] arg= new int[26];
        for(int  i=0;i<s.Length;i++){
            arg[s[i]-'a']++;
            arg[t[i]-'a']--;
        }
        for(int  i=0;i<arg.Length;i++){
            if(arg[i]>0) return  false;
        }
        return true;


    }
}
