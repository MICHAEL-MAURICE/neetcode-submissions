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
    public void ReorderList(ListNode head) {
        ListNode fast=head;
        ListNode slow= head;

        while( fast.next!=null && fast.next.next!=null){
            slow=slow.next;
            fast=fast.next.next;
        }
        ListNode second=slow.next;
        slow.next = null;
        ListNode p1=null;
          while(second!=null){
            ListNode p3=second.next;
            second.next=p1;
            p1=second;
            second=p3;
          }
          ListNode first=head;
           second=p1;
          while(second!=null){
            ListNode t1= first.next;
            ListNode t2 =second.next;
            first.next=second;
            second.next=t1;
            first=t1;
            second=t2;
          }
    }
}
