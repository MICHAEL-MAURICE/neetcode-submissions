public class Solution {
    public int EvalRPN(string[] tokens) {

        if(tokens.Length == 1) return int.Parse(tokens[0]);
        int result=0;
        int count=0;
        Stack<int> stack= new Stack<int>();
        foreach(var s in tokens){
            if(s=="+"){
              int a=stack.Pop();
              int b= stack.Pop();
              result=a+b;  
              stack.Push(result);
            }
            else if(s=="-"){
                  int a=stack.Pop();
              int b= stack.Pop();
              result=b-a; 
              stack.Push(result);
                
            }
            else if(s=="*"){
  int a=stack.Pop();
              int b= stack.Pop();
              result=a*b; 
              stack.Push(result);
            }
            else if(s=="/"){
                    int a=stack.Pop();
              int b= stack.Pop();
              result=(int)b/a; 
              stack.Push(result);
        
            }
                    else 
              stack.Push(int.Parse(s));
        }

        return result;
    }
}
