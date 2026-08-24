public class Solution {
    public int LengthOfLongestSubstring(string s) {
      int j=0;
      int res=0;
      HashSet<char> set= new ();
      for(int i=0;i<s.Length;i++){
        while(set.Contains(s[i])){
            set.Remove(s[j]);
            j++;
        }
        set.Add(s[i]);
        res=Math.Max(res,set.Count);
      }
      return res;
    }
}
