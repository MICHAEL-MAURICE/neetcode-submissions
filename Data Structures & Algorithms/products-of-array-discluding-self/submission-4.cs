public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int countZeros=0;
        int mul=1;
        int len= nums.Length;
        List<int>res= new List<int>();
        foreach(var n in nums){
            if(n==0){
                mul*=1;
                countZeros++;
            }
            else{
                mul*=n;
            }
        }
 foreach(var n in nums){


 if((countZeros==1 && n!=0 )|| countZeros>1){
        res.Add(0);
        }
      
      else if(n==0){
        res.Add(mul);
      }
      
      
      else{
         res.Add(mul/n);
      }
 }

 return res.ToArray();

    }
}
