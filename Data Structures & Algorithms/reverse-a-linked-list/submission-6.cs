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
    public ListNode ReverseList(ListNode head) {
        if(head==null) return head;
        ListNode p1=null;
        ListNode p2=head;
        ListNode p3=head.next;


        while(p2!= null){
         
          p2.next=p1;
          p1=p2;
          p2=p3;
          if(p3!=null )p3=p3.next;
    
        }

        return p1;
    }
}
