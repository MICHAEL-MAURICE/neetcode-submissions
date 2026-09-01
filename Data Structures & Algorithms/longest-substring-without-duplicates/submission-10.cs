public class Solution {
    public int LengthOfLongestSubstring(string s) {
      HashSet<char> set= new HashSet<char>();
      int i=0;
      int j=0;
      var res=0;
      while(j<s.Length){
        if(!set.Contains(s[j])){
          set.Add(s[j]);
          j++;
        }
        else{
          set.Remove(s[i]);
          i++;
          
        }
        
  res=Math.Max(res,set.Count);

      }

      return res;
    }
}
