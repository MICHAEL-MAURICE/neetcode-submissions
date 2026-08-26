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
        Queue<TreeNode>q=new();
        List<List<int>> result=new();
        if(root!=null)q.Enqueue(root);

        while(q.Count>0){
            var levelCount=q.Count;
            List<int>innerList=new();
            for(int i=0;i<levelCount;i++){
                var v= q.Dequeue();
                innerList.Add(v.val);
                if(v.left!=null){
                    q.Enqueue(v.left);
                }
                if(v.right!=null){
                    q.Enqueue(v.right);
                }
            }
            result.Add(innerList);
        }

        return result;
    }
}
