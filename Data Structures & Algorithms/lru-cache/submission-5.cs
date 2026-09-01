public class LRUCache {
private Dictionary<int,int>LRU;
private LinkedList<int>LeastUsed;
private int capacity;
    public LRUCache(int capacity) {
        this.capacity=capacity;
        LRU=new Dictionary<int,int>();
        LeastUsed=new LinkedList<int>();
    }
    
    public int Get(int key) {
        if(!LRU.ContainsKey(key)){return -1;}
       LeastUsed.Remove(key);
       LeastUsed.AddLast(key);
       return LRU[key];    
    }
    
    public void Put(int key, int value) {
        if(LRU.ContainsKey(key)){
            LeastUsed.Remove(key);
            LeastUsed.AddLast(key);
            LRU[key]=value;
            return;
        }

         if(capacity==LRU.Count){
            var deletedValue= LeastUsed.First.Value;
            LeastUsed.RemoveFirst();
            LRU.Remove(deletedValue);
        }

        LRU[key]=value;
        LeastUsed.AddLast(key);


    }
}
