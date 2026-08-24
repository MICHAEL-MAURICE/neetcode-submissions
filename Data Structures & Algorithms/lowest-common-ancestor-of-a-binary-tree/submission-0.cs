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
    private TreeNode loc=null;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
         
Dfs(root,p,q);
return loc;

    }

    private (bool,bool)Dfs(TreeNode root, TreeNode p, TreeNode q){
        if(root==null || loc!=null) return (false,false);

        var left= Dfs(root.left,p,q);
        var right= Dfs(root.right,p,q);

        var foundp= left.Item1 || right.Item1 || root==p;
        var foundQ= left.Item2 || right.Item2 || root==q;

      if (foundp && foundQ && loc == null) {
            loc = root;
        }
        return (foundp, foundQ);
    }
}