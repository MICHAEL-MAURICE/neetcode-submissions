public class Solution {
    public int CharacterReplacement(string s, int k) {
        int l=0;
        int res=0;
        int finalres=0;
        Dictionary<char,int> count= new();

        for(int i=0;i<s.Length;i++){
          if(count.ContainsKey(s[i])){
            count[s[i]]++;

          }
          else 
          count[s[i]]=1;
         
         res= Math.Max(res,count[s[i]]);

         if((i-l+1)-res>k){
          count[s[l]]--;
          l++;
         }
finalres= Math.Max(finalres,i-l+1);

        }

        return finalres;
    }
}
