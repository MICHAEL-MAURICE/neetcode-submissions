public class Solution {
    public bool IsPalindrome(string s) {
        char[] chars= s.ToCharArray();
        int i =0; 
        int j= s.Length-1;
        while(i<j){
            if(char.IsDigit(chars[i]) || char.IsLetter(chars[i])){
 if( (char.IsDigit(chars[j]) || char.IsLetter(chars[j]))){
        
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
