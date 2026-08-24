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
       var current=head;
        var list= new List<int>();

        while(current!=null){
            list.Add(current.val);
            current=current.next;
        }
        
          int i = 0;
        int j = list.Count-1 ;
         current=head;
        while (i<=j && (current!=null )) {
            current.val=list[i];
            i++;
           

            current=current.next;
            if(i>j) break;
            current.val=list[j];
            j--;
            if(current.next!=null)
              current=current.next;

        }

        //return head;
    }
}
