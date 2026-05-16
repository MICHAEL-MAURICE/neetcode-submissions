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
    public bool HasCycle(ListNode head) {
      
        ListNode s=head;
        ListNode f=head;

        while (f!=null && f.next!=null)
        {
           
            s=s.next;
            f=f.next.next;
            if(s.Equals(f))return true;
        }

        return false;
    }
}
