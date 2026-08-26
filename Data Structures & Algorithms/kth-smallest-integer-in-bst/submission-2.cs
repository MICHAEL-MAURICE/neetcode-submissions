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
    private int count=0;
    private int answer=0;

    public int KthSmallest(TreeNode root, int k) {
        dfs(root,k);
        return answer;
    }
    private void dfs(TreeNode root, int k) {
        if(root==null)return ;

        dfs(root.left,k);

        count++;
        if(count==k) {
            answer=root.val; 
            return;
            }

            dfs(root.right,k);
    }
}
