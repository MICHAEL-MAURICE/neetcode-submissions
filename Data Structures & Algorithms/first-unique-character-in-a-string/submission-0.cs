public class Solution {
    public int FirstUniqChar(string s) {
        int []ch= new int[26];
        for(int i=0;i<s.Length;i++){
        
                ch[s[i]-'a']++;
            
        }
  for(int i=0;i<s.Length;i++){

 if(ch[s[i]-'a']==1){
    return i;}
  }
          return -1;


    }
}