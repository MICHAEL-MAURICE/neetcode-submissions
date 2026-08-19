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
        ListNode current=head;
        int counter=0;
        int  length=0;
        while (current!= null){
            length++;
            current =current.next;
        }
        int number=length-n;
        if (number == 0) return head.next;
        current=head;

 while (current!= null){
            counter++;
            if(number==counter) {
                current.next=current.next.next;
                break;
            }
            
            current=current.next;
        }


        return  head;
    }
}
