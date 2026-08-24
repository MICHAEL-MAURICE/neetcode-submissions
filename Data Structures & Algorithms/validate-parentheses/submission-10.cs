public class Solution {
    public bool IsValid(string s) {
        Stack<char> st= new();
        foreach(var ch in s){
            if(ch=='{' || ch=='[' || ch=='('){
                st.Push(ch);
            }
             else{
                 if(st.Count == 0) return false;
             var top = st.Pop();

               if(top=='[' && ch !=']') return false;
               if(top=='{' && ch !='}') return false;
               if(top=='(' && ch !=')') return false;
             }
        }

        if(st.Count == 0) return true;
        return false;
    }
}
