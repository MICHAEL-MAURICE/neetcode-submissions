public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int mult=1;
        int zeroesCount=0;
        List<int>retur=new List<int>();
        foreach(var num in nums){
            if(num!=0){
                mult*=num;
            }
            else{
                zeroesCount++;
            }
        }
        if(zeroesCount >1){
            return new int[nums.Length];
        }

        foreach(var num in nums){
            if(zeroesCount >0){
                var prod= num ==0 ? mult : 0;
                retur.Add(prod);
            }
            else{
retur.Add(mult / num);
            }
        }

        return retur.ToArray();
    }
}
