public class Solution {
    public bool IsAnagram(string s, string t) {
      // if (s.Length != t.Length)return false;
       int []ans= new int[26];
       foreach(char ch in s){
         ans[ch-'a']++;
       }
       foreach(char ch in t){
         ans[ch-'a']--;
       }
       foreach (char ch in ans){
         if(ch!=0)return false;
       }
       return true;
    }
}
