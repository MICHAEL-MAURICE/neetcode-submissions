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
    private List<int>res=new();
    public List<int> RightSideView(TreeNode root) {
    dfs(root,0);
    return res;
    }
    private void dfs(TreeNode root, int depth){
        if(root==null)return ;


        if(res.Count==depth){
            res.Add(root.val);
        }

        dfs(root.right,depth+1);
        dfs(root.left,depth+1);
    }

}
