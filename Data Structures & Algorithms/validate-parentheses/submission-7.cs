public class Solution {
    public bool IsValid(string s) {
        if(s.Length==1) return false;
        Stack<char>st=  new Stack<char>();
        foreach(var ch in s){
            if(st.Count>0 &&((ch==']' && st.Peek()=='[')  || (ch=='}' && st.Peek()=='{') || (ch==')' && st.Peek()=='('))){
                st.Pop();
            }
            
            else{
                 st.Push(ch);
            }
        }

        if(st.Count>0) return false;
        return true;
    }
}
