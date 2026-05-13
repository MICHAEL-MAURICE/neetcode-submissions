public class Solution {
    public bool IsValid(string s) {
     if (s.Length == 1) return false;
        Stack<char>stack=new Stack<char>();

        foreach(var ch in s){
            if(ch=='(' ||ch=='[' || ch=='{' )
            stack.Push(ch);
            else {
                
                if (stack.Count > 0 && 
                      ((stack.Peek() == '(' && ch == ')') ||
                       (stack.Peek() == '[' && ch == ']') ||
                       (stack.Peek() == '{' && ch == '}'))) {
                    stack.Pop();
                }
else return false;
        }
        }
return stack.Count==0;

    }
}
