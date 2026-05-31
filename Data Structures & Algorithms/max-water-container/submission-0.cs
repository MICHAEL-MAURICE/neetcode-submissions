public class Solution {
    public int MaxArea(int[] heights) {
        int amount=0,maxamount=0;
    int i=0,j=heights.Length-1;
    while(i<j){
if(heights[i]>heights[j]){
    amount=heights[j]*(j-i);
    maxamount=Math.Max(maxamount,amount);
    j--;
}
else if(heights[i]<heights[j]){
 amount=heights[i]*(j-i);
    maxamount=Math.Max(maxamount,amount);
i++;
}
else{
     amount=heights[i]*(j-i);
    maxamount=Math.Max(maxamount,amount);
    i++;
    j--;
}

    }

    return maxamount;
    }
}
