public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length==1)return 1;
int res=0;
HashSet<char>counter=new HashSet<char>();
int j=0;
foreach(var ch in s){
    while(counter.Contains(ch)){
        counter.Remove(s[j]);
        j++;
    }
    counter.Add(ch);
    res=Math.Max(res,counter.Count);
}
return res;
}
}