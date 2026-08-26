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
    public List<int> RightSideView(TreeNode root) {
      var q= new Queue<TreeNode>();
      List<int>res=new();
      if(root!=null)q.Enqueue(root);
      while(q.Count>0){
        var count= q.Count;
        TreeNode rightNode=null;
        for(int i=0;i<count;i++){
            var node=q.Dequeue();
            if(node!=null){
                rightNode=node;
                q.Enqueue(node.left);
                q.Enqueue(node.right);
            }
        }

        if(rightNode!=null){
            res.Add(rightNode.val);
        }
      }

      return res;

    }
}
