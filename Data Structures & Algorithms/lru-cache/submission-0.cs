public class LRUCache {
private Dictionary<int,int>LRU;
private LinkedList<int>usage;
private int capacity;
    public LRUCache(int capacity) {
        this.LRU= new Dictionary<int,int>();
        this.usage= new LinkedList<int>();
        this.capacity=capacity;
    }
    
    public int Get(int key) {
        if(!LRU.ContainsKey(key))return -1;
        usage.Remove(key);
        usage.AddLast(key);

        return LRU[key];
    }
    
    public void Put(int key, int value) {
        if(LRU.ContainsKey(key)){
            usage.Remove(key);
           
            LRU[key]=value;
            usage.AddLast(key);
            return;
        }
        if(LRU.Count==capacity){
            var getfirst=usage.First.Value;
            usage.RemoveFirst();
            LRU.Remove(getfirst);

        }
          LRU[key]=value;
          usage.AddLast(key);

    }
}
