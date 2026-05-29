public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var reternedlist= new List<List<string>>();
        Dictionary<string,List<string>> anag=new Dictionary<string,List<string>>();
        var list=new List<string>();
        foreach(var s in strs){
            list=new List<string>();
            char[] schar= s.ToCharArray();
            Array.Sort(schar);
             foreach(var ss in strs){
              char[] sschar= ss.ToCharArray();
            Array.Sort(sschar);

            if(new string(schar) ==new string(sschar)){
                list.Add(ss);
            }
             }
             if (!anag.ContainsKey(new string(schar))) {
    anag[new string(schar)] = new List<string>();
}
anag[new string(schar)].Add(s);
        }

        foreach(var dic in anag){
reternedlist.Add(dic.Value);
        }

        return reternedlist;
    }
}
