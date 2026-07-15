public class Solution {
    public bool IsAnagram(string s, string t) {
          char[] Schars = s.ToCharArray();
          Array.Sort(Schars);
          char[] Tchars = t.ToCharArray();
          Array.Sort(Tchars);
          return new string(Schars) == new string(Tchars);
    }
}
