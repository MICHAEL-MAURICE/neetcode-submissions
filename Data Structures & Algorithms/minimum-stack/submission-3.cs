public class MinStack {
    private Stack<int> stack;
    private Stack<int>ministack;
    

    public MinStack() {
       this.stack=new Stack<int>();
       this.ministack= new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(ministack.Count==0 || val<=ministack.Peek()){
            ministack.Push(val);
        }
    }
    
    public void Pop() {
        if(stack.Count<=0)return;
        var value=stack.Pop();
        if(value == ministack.Peek()){
            ministack.Pop();
        }

    }
    
    public int Top() {
         if(stack.Count<=0)return -1;
      return  stack.Peek();
    }
    
    public int GetMin() {
         if(ministack.Count<=0)return -1;
        return ministack.Peek();
    }
}
