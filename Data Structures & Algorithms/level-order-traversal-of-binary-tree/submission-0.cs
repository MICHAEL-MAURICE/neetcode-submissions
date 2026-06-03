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
    public List<List<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode>queue= new Queue<TreeNode>();
        List<List<int>>returns=new List<List<int>>();
        if(root!=null){
            queue.Enqueue(root);
        }
        while(queue.Count> 0){

            var levelcount= queue.Count;
             List<int>levellist= new List<int>();
            for(int i=0;i< levelcount;i++){
                var q=queue.Dequeue();
                levellist.Add(q.val);
                if(q.left!=null){
                     queue.Enqueue(q.left);
                }
                if(q.right!= null){
                     queue.Enqueue(q.right);
                }

            }
            returns.Add(levellist);

        }

        return returns;
    }
}
