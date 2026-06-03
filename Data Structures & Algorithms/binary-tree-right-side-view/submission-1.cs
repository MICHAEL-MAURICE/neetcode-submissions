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
        q.Enqueue(root);
        List<int> returnresult= new List<int>();
        while(q.Count>0){
           TreeNode rightSide = null;
            var levelcount= q.Count;
            
             for(int  i=0;i<levelcount;i++){
                 var node= q.Dequeue();
                   if (node != null) {
                    rightSide = node;
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }
            if (rightSide != null) {
                returnresult.Add(rightSide.val);
            }
                 

             
        }
        return returnresult;
        
    }
}
