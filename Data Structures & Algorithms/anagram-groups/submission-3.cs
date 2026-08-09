public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
Dictionary<string, List<string>> group = new Dictionary<string, List<string>>();
        foreach(var str in strs){
            char[]strarr= str.ToCharArray();
                 Array.Sort(strarr);
          string key = new string(strarr);
       if (!group.ContainsKey(key))
        group[key] = new List<string>();
        group[key].Add(str);
        }
       return group.Values.ToList();
    }
}
