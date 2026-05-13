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
        if (head ==null) return head;
        ListNode fir= head;
        ListNode sec=head.next;
        if(sec==null)return head;
        ListNode thir= sec.next;

        while (sec != null){
            thir= sec.next;
            sec.next=fir;
            fir=sec;
           // fir.next=thir;
            sec=thir;
        }

        head.next=null;
        return fir;
    }
}
