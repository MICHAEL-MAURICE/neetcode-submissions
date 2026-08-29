public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int []count=new int [26];
        foreach(var ch in tasks){
            count[ch-'A']++;
        }

        Array.Sort(count);

        var maxf=count[25];
        var repc=(maxf-1) * n;
      
      for(int i=24;i>=0;i--){
        repc-=Math.Min(maxf-1,count[i]);
      }

      return Math.Max(repc,0) +tasks.Length;


    }
}
