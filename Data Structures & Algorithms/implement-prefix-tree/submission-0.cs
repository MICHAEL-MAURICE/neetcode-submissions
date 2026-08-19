public class PrefixNode(){
  public bool isEndNode;
  public Dictionary<char,PrefixNode>children=new();
}


public class PrefixTree {
public PrefixNode root;

    public PrefixTree() {
        root= new PrefixNode();
    }
    
    public void Insert(string word) {
        var current= root;
        foreach (var c in word){
          if(!current.children.ContainsKey(c)){
            current.children[c]=new PrefixNode();
          }
          current=current.children[c];

        }
        current.isEndNode=true;
    }
    
    public bool Search(string word) {
        var current =root;
        foreach(char c in word){
            if(!current.children.ContainsKey(c)) return false;

             current= current.children[c];
        }
       return current.isEndNode;
    }
    
    public bool StartsWith(string prefix) {
        var current= root;
        foreach(char c in prefix){
            if(!current.children.ContainsKey(c)){
                return false;
            }
              current= current.children[c];
        }

        return true;
    }
}
