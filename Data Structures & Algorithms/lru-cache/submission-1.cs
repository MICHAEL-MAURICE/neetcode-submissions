public class LRUCache {
private Dictionary<int,int>LRU;
private LinkedList<int> usage;
private int capacity;
    public LRUCache(int capacity) {
        LRU= new Dictionary<int,int>();
        this .usage=new();
        this.capacity=capacity;
    }
    
    public int Get(int key) {
        if(!LRU.ContainsKey(key)) return -1;
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
        if(capacity==LRU.Count){
            var lastusage= usage.First.Value;
            usage.RemoveFirst();
            LRU.Remove(lastusage);
        }

        LRU[key]=value;
        usage.AddLast(key);
    }
}
