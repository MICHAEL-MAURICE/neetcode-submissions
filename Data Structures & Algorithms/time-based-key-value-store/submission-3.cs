public class TimeMap {
Dictionary<string,List<(int t,string s)>>map;
    public TimeMap() {
        map=new();
    }
    
    public void Set(string key, string value, int timestamp) {
        if(!map.ContainsKey(key)){
            map[key]=new List<(int t,string s)>();
        }
         map[key].Add((timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        if(!map.ContainsKey(key)) return "";
          var searchlist= map[key];

          int s=0;
          int e= searchlist.Count-1;
           var result="";
          while(s<=e){
            var mid= s+(e-s)/2;
            if(searchlist[mid].t<=timestamp){
                result = searchlist[mid].s;
                s=mid+1;
            }
            else{
                e=mid-1;
            }
          }
return result;
    }
}
