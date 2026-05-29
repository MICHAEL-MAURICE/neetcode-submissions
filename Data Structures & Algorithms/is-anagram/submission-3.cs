public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if(s.Length !=t.Length) return false;
   int [] countchars = new int[26];

   for(int i=0;i<s.Length;i++){
    countchars[s[i] - 'a']++;
    countchars[t[i] - 'a']--;
   }
for(int i=0;i<countchars.Length;i++){
    if(countchars[i]!=0)return false;
}

return true;
       
    }
}
