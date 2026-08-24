/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if(head==null) return null;
        var current=head;
        Dictionary<Node,Node> dec= new();
        
        while(current!=null){
            dec[current]=new Node(current.val);
            current=current.next;
        }

        current=head;

        while(current!=null){
            dec[current].next=current.next!=null?dec[current.next]:null;
            current=current.next;
        }
          current=head;

while(current!=null){
            dec[current].random=current.random!=null?dec[current.random]:null;
            current=current.next;
        }

        return dec[head];
    }
}
