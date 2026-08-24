public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> n1= new HashSet<int>(nums1); 
        HashSet<int> n2= new HashSet<int>(nums2); 
        Dictionary<int,int>dic= new Dictionary<int,int>();
        foreach(var n in n1){
            if(dic.ContainsKey(n)){
                dic[n]++;
            }
            else dic[n]=1;
        }

         foreach(var n in n2){
            if(dic.ContainsKey(n)){
                dic[n]++;
            }
            else dic[n]=1;
        }

    return dic.Where(x=>x.Value==2).Select(x=>x.Key).ToArray();

    }
}