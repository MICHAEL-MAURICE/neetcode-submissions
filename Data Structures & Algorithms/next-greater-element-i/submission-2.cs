public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        Dictionary<int,int>num1idex=new();
        for(int i=0;i<nums1.Length;i++){
         num1idex[nums1[i]]=i;
        }
        var ans=  new int[nums1.Length];
        Array.Fill(ans,-1);
        Stack<int>stack=new();

        for(int j=0;j<nums2.Length;j++){
            var num=nums2[j];
            while(stack.Count > 0 && num >stack.Peek()){
                var value= stack.Pop();
                if(num1idex.ContainsKey(value)){
                    var idx=num1idex[value];
                    ans[idx]=num;
                }
            }

            if(num1idex.ContainsKey(num)){
                stack.Push(num);
            }

        }

        return ans;
    }
}