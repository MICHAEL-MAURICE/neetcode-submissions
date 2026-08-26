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
    private bool blanced=true;
    public bool IsBalanced(TreeNode root) {
      var res= dfs(root);
      return blanced;    
    }

  private int dfs(TreeNode node){
    if(node==null)return 0; 

    var left= dfs(node.left);
    var right = dfs(node.right);
    if(Math.Abs(left-right)>1) blanced= false;
    return 1+Math.Max(left,right);

  }

}
