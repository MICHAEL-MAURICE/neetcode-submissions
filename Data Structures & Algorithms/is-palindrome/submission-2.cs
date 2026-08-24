public class Solution {
    public bool IsPalindrome(string s) {
        var chars= s;
        int i =0; 
        int j= s.Length-1;
        while(i<j){
            if(char.IsLetterOrDigit(chars[i])){
 if((char.IsLetterOrDigit(chars[j]))){
        
  if(char.ToLower(chars[i])==char.ToLower(chars[j])){
                    i++;
                    j--;
                }
                else{
                    return false;
                }

            }
            else{
                j--;
            }
            }
            else{
                i++;
            }

           
        }

        return true;
    }
}
