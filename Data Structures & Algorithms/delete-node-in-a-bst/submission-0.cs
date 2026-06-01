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

     public TreeNode minval(TreeNode root){
        if(root is null) return null;
         TreeNode curr = root;
        while(curr!=null && curr.left !=null){
            curr=curr.left;
        }
        return curr;
     }
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root is null)return null;
        if(root.val< key){
            root.right=DeleteNode(root.right,key);
        }
        else if (key<root.val){
            root.left=DeleteNode(root.left,key);
        }
        else{
             if (root.left == null)
            {
                return root.right;
            }
            else if (root.right == null)
            {
                return root.left;
            }
            else{
                TreeNode minnode=minval(root.right);
                root.val=minnode.val;
                root.right=DeleteNode(root.right,minnode.val);

            }
        }
        return root;
    }
}