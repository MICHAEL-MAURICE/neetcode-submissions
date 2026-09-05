public class Solution {
    public bool IsAnagram(string s, string t) {
      if(s.Length!=t.Length) return false;
  int[]count=new int[26];

  foreach (var ch in s){
  count[ch-'a']++;
  }
  foreach (var ch in t){
  count[ch-'a']--;
  }
 foreach(var num in count){
  if(num>0)return false;
 }
    return true;
    }
}
