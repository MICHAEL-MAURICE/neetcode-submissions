/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    private TreeNode res=null;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        Dfs(root,p,q);
        return res;

    }

    private (bool,bool)Dfs(TreeNode node, TreeNode p, TreeNode q){
          if(node==null || res!=null) return (false,false);

          var left=Dfs(node.left,p,q);
          var right=Dfs(node.right,p,q);


          var foundP = left.Item1 || right.Item1 || node==p;
          var foundQ = right.Item2 || left.Item2 || node == q;
          if(foundP && foundQ && res==null ){
            res=node;
          }

          return (foundP,foundQ);
    }
}