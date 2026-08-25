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
    private TreeNode res=null;
    private int minvalue=-900;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        Dfs(root,p,q);
        return res;
    }

    private (bool,bool) Dfs(TreeNode node, TreeNode p, TreeNode q){
      
      if(node==null){
        return (false,false);
      }

      var left=  Dfs(node.left,p,q);
      var right= Dfs(node.right,p,q);

      var foundP= left.Item1 || right.Item1 ||node==p;
      var foundQ= left.Item2 || right.Item2 || node==q; 

      if(foundP && foundQ ){
        if(res == null){
            res=node;
        }
      }

       return (foundP , foundQ);

    }
}
