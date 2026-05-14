public class Solution {
    public int LengthOfLongestSubstring(string s) {
int left=0;
int max=0;
HashSet<char> chars = new HashSet<char>();
for(int i=0;i<s.Length;i+=1){
while(chars.Contains(s[i])){
    chars.Remove(s[left]);
    left+=1;
}
chars.Add(s[i]);
max=Math.Max(max,(i-left)+1);


}

return max;
    }
}
