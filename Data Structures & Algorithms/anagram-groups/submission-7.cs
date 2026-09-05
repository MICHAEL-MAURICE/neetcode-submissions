public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>>result=new();
        Dictionary<string,List<string>>sortedAnagrams=new();
        foreach(var s in strs){
            var charstr= s.ToCharArray();
            Array.Sort(charstr);
            var sortedstr=new string(charstr);
            if(!sortedAnagrams.ContainsKey(sortedstr))
                sortedAnagrams[sortedstr]= new List<string>();
                
                sortedAnagrams[sortedstr].Add(s);
            
        }
          return sortedAnagrams.Select(x=>x.Value).ToList();
    }
}
