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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        if(l1==null)return l2;
        if(l2==null) return l1;
        int sum=0;
        int remain=0;
        ListNode res=new ListNode(0);
        var curr=res;
        var curr1= l1;
        var curr2=l2;
        while(curr1!=null || curr2!=null ||remain!=0 ){
        
             int v1 = (curr1 != null) ? curr1.val : 0;
             int v2 = (curr2 != null) ? curr2.val : 0;
            sum= v1 + v2 +remain;
            remain=sum/10;
            sum=sum%10;
            curr.next = new ListNode(sum); 
            curr = curr.next;
          
             curr1 = (curr1 != null) ? curr1.next :null;
             curr2 = (curr2 != null) ? curr2.next :null;
        }
       
 return res.next;
    }
}
