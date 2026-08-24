/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int len=0;
       var curr=head;

       while(curr!=null){
        len++;
        curr=curr.next;
       }
       var removedNode=len-n;
        if (removedNode == 0)
            return head.next;
       curr=head;
       len=1;

        while(curr!=null){
       
      
        if(len==removedNode){
            curr.next=curr.next.next;
            break;
        }
          curr=curr.next;
           len++;
       }

return head;
    }
}
