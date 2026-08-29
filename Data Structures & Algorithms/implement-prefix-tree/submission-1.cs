public class PrefixNode{
   public Dictionary<char,PrefixNode>children=new();
   public bool isEndNode;
}

public class PrefixTree {
PrefixNode root;
    public PrefixTree() {
        root = new PrefixNode();
    }
    
    public void Insert(string word) {
        var current=root;
        foreach(var ch in word){
            if(!current.children.ContainsKey(ch)){
               current.children[ch]=new PrefixNode();
            }
            current=current.children[ch];
        }
        current.isEndNode=true;
    }
    
    public bool Search(string word) {
        var current=root;
        foreach(var c in word){
            if(!current.children.ContainsKey(c)) return false;

            current=current.children[c];
        }

        return current.isEndNode;
    }
    
    public bool StartsWith(string prefix) {
        var current=root;
        foreach(var ch in prefix) {
            if(!current.children.ContainsKey(ch)) return false;

            current=current.children[ch];
        }     
        return true;
    }
}
