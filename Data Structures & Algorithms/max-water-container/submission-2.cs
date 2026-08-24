public class Solution {
    public int MaxArea(int[] heights) {
        int result=0;
        int i=0;
        int j= heights.Length-1;

        while(j>i){
          result=Math.Max(result,((j-i)* Math.Min(heights[i],heights[j])));
         if(heights[i]<heights[j]){
            i++;
         }
         else{
            j--;
         }
                      
        }

        return result;
        

    }
}
