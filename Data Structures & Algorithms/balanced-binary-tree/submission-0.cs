public class Solution
{
    bool balanced = true;

    int Inorder(TreeNode node)
    {
        if (node == null)
            return 0;

        int countleft = Inorder(node.left);
        int countright = Inorder(node.right);

        if (Math.Abs(countleft - countright) > 1)
            balanced = false;

        return Math.Max(countleft, countright) + 1;
    }

    public bool IsBalanced(TreeNode root)
    {
        Inorder(root);
        return balanced;
    }
}