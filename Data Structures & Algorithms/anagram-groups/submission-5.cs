public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>>result= new Dictionary <string,List<string>>();

        foreach (var wo in strs){
            var ch = wo.ToCharArray();
            Array.Sort(ch);
            var s= new String(ch);
            if(!result.ContainsKey(s))
                result[s]= new List<string>();

                result[s].Add(wo);
        }


        return result.Select(x=>x.Value).ToList();
    }
}
