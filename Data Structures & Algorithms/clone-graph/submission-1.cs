/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        Dictionary<Node,Node>oldTonew=new();
        return Dfs(node,oldTonew);
    }

   private Node Dfs(Node node,Dictionary<Node,Node> oldTonew){
    if(node==null)return null;

    if(oldTonew.ContainsKey(node)){
        return oldTonew[node];
    }

    var copy= new Node(node.val);
    oldTonew[node]=copy;
   
   foreach(var nod in node.neighbors){
   copy.neighbors.Add(Dfs(nod,oldTonew));
   }

   return copy;

   }

}
