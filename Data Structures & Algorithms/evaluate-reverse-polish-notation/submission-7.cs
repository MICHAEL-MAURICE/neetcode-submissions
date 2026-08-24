public class Solution {
    public int EvalRPN(string[] tokens) {
        int res=0;
        Stack<int>stack=new Stack<int>();
        foreach(var ch in tokens ){
            if(ch =="+"){
                var num1=stack.Pop();
                var num2=stack.Pop();
              res=(num1+num2);
               stack.Push(res);

            }
            else if(ch =="-"){
                var num1=stack.Pop();
                var num2=stack.Pop();
                res=num2 - num1  ;
                 stack.Push(res);
            }
            else if(ch =="*"){
                var num1=stack.Pop();
                var num2=stack.Pop();
                res=num1* num2;
                 stack.Push(res);
            }
            else if(ch =="/"){
                var num1=stack.Pop();
                var num2=stack.Pop();
                res=num2/num1;
                stack.Push(res);
            }
            else{
                stack.Push(int.Parse(ch));
            }

        }

        return stack.Pop();
    }
}
