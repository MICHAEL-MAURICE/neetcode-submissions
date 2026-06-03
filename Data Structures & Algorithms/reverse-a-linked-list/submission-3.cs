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
        
        if(head==null) return null;
         ListNode pointer1=null;
         ListNode pointer2=head;
         while(pointer2!=null){
            ListNode pointer3=pointer2.next;

            pointer2.next=pointer1;
            pointer1=pointer2;
            pointer2=pointer3;

         }
          
         return pointer1;


    }
}
