public class Solution {
    public bool IsAnagram(string s, string t) {
             if(s.Length !=t.Length)return false;
             int []counter= new int[26];
             foreach(var ch in s){
                counter[ch-'a']++;
             }
             foreach(var ch in t){
                counter[ch-'a']--;
             }
             for(int i=0;i<26;i++){
                if(counter[i]>0)return false;
             }

             return true;
    }
}
