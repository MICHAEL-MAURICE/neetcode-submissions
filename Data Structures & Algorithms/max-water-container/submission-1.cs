public class Solution {
    public int MaxArea(int[] heights) {
        int res=0;
       
        int  l=0,r=heights.Length-1;
        while (r>l){
           var area= Math.Min(heights[l],heights[r])*(r-l);
           res= Math.Max(res,area);
           if(heights[l]>heights[r]){
            r--;
           }
 else{
            l++;
           }


        }

        return res;
    }
}
