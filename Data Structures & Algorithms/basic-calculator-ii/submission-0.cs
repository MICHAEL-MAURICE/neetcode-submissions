public class Solution {
    public int Calculate(string s) {
        s=s.Trim();
        Console.WriteLine(s);
        char op='+';
        int num=0;
        Stack<int> st=new();
        for(int i=0;i<s.Length;i++){
            var ch=s[i];
            if(char.IsDigit(ch)){
                num=num*10+(ch-'0');
            }
          if ((!char.IsDigit(ch) && ch!=' ' )|| i==s.Length-1){
                 if(op=='+'){
                    st.Push(num);
                 }
                 else if(op=='-'){
                    st.Push(-num);
                 }
                 else if(op=='*'){
                    var prev=st.Pop();
                    st.Push(prev*num);
                 }
                 else{
                     var prev=st.Pop();
                    st.Push(prev/num);
                 }
                 op = ch;
                 num = 0;

            }
        }

int res=0;
 while (st.Count > 0) {
            res += st.Pop();
        }
return res;

    }
}