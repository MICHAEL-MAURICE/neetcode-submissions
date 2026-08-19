public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        var l=1;
        var r= piles.Max();
        var res=r;
        while(l<=r){
           int mid=l + (r - l) / 2;
           
           long totalTime = 0;
            foreach (int p in piles) {
                totalTime += (int)Math.Ceiling((double)p / mid);
            }
           if(totalTime<=h){
            res=mid;
            r=mid-1;
           }
           else{
            l=mid+1;
           }


        }

        return res;
    }
}
