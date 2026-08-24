public class LRUCache {
Dictionary<int, int>LRU;
LinkedList<int>linked;
int capacity;

    public LRUCache(int capacity) {
        this.LRU=new();
        this.linked=new();
        this.capacity=capacity;
    }
    
    public int Get(int key) {
        if(!LRU.ContainsKey(key)) return -1;
        linked.Remove(key);
        linked.AddLast(key);
        return LRU[key];
    }
    
    public void Put(int key, int value) {
        if(LRU.ContainsKey(key)){
            linked.Remove(key);
            linked.AddLast(key);
            LRU[key]=value;
            return;
        }

        if(capacity==LRU.Count){
          var firstvalue= linked.First.Value;
          linked.RemoveFirst();
          LRU.Remove(firstvalue);
        }

       linked.AddLast(key);
        LRU[key]=value;
        
            }
}
