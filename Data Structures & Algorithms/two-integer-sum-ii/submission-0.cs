public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        Dictionary<int,int> twosum= new Dictionary<int,int>();
        
        for(int i=0;i<numbers.Length;i++){
         int rem= target-numbers[i];
         if(twosum.ContainsKey(rem)){
            return new int[]{twosum[rem],i+1};
         }
         else{
            twosum.Add(numbers[i],i+1);
         }
        }

        return null;
        
    }
}
