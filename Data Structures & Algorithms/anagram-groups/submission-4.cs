public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> res= new List<List<string>>();
        Dictionary<string,List<string>> val=  new Dictionary<string,List<string>>();
        foreach( var s in strs){
            var ch=s.ToCharArray();
            Array.Sort(ch);
            var newstring= new String(ch);
            if(!val.ContainsKey(newstring))
             val[newstring] = new List<string>();
             val[newstring].Add(s);
        }

        foreach(var dic in val){
            res.Add(dic.Value);
        }

        return res;
    }
}
