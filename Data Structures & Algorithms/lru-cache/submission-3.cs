public class LRUCache {
 Dictionary <int,int>map=new Dictionary<int,int>();
 LinkedList<int> list=new LinkedList<int>();
 int capacity=0;
    public LRUCache(int capacity) {
       this.capacity=capacity;
    }
    
    public int Get(int key) {
        if(!map.ContainsKey(key)) return -1;
        list.Remove(key);
        list.AddLast(key);

        return map[key];
    }
    
    public void Put(int key, int value) {
        if(map.ContainsKey(key)){
            list.Remove(key);
            list.AddLast(key);
            map[key]=value;
            return;
        }
        if(capacity==map.Count){
          var firstvalue= list.First.Value;
          list.RemoveFirst();
          map.Remove(firstvalue);
        }
        map[key]=value;
        list.AddLast(key);
    }
}
