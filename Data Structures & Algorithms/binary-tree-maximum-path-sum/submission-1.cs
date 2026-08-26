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
    public int MaxPathSum(TreeNode root) {
     var res=int.MinValue;
     var x= Dfs(root, ref res);
    return res;
    }

    private int Dfs(TreeNode root,ref int res){
      if(root==null) return 0;


      var leftMax=Math.Max(Dfs(root.left,ref res),0);
      var rightMax=Math.Max(Dfs(root.right,ref res),0);


      res=Math.Max(res,root.val+leftMax+rightMax);


      return root.val+Math.Max(leftMax,rightMax);




    }
}
