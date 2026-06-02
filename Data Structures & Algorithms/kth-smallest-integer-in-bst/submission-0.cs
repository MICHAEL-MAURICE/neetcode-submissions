/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
 int count=0;
 int answer=0;
    public int KthSmallest(TreeNode root, int k) {
           inorder(root,k);
           return answer;
    
     
    }

public void inorder(TreeNode root, int k){
    if (root == null) return ;
    inorder(root.left,k);
    count++;
    if(count==k){
        answer=root.val;
        return;
    }
    inorder(root.right,k);
}

}
