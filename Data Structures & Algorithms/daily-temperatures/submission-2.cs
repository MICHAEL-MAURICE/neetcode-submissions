public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
       int n= temperatures.Length;
        int [] res= new int[n];
        Stack<int[]>stack=new();
        for(int i=0;i<n;i++){
            var t= temperatures[i];
           // var lastTemp= ;
            while(stack.Count>0 && t>stack.Peek()[0]){
                var pair= stack.Pop();
                res[pair[1]]=i-pair[1];
            }
            stack.Push([t,i]);
        }

        return res;
    }
}
