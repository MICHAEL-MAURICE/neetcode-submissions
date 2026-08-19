public class PrefixNode(){
  public bool isEndNode;
  public Dictionary<char,PrefixNode>children=new();
}

public class WordDictionary {

public PrefixNode root;

    
      

    public WordDictionary() {
          root= new PrefixNode();
    }
    



    public void AddWord(string word) {
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
         return SearchDfs(word,0,root);
    }

private bool SearchDfs(string word, int index, PrefixNode current) {
    // Base case: reached end of word
    if (index == word.Length) {
        return current.isEndNode;
    }
    
    char c = word[index];
    
    if (c == '.') {
        // Try ALL children
        foreach (var child in current.children.Values) {
            if (SearchDfs(word, index + 1, child)) {
                return true;
            }
        }
        return false;
    } else {
        // Exact character match
        if (!current.children.ContainsKey(c)) {
            return false;
        }
        return SearchDfs(word, index + 1, current.children[c]);
    }
}





}
