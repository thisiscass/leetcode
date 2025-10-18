var root = new TreeNode(1);
var left = new TreeNode(2);
var right = new TreeNode(3);

root.left = left;
root.right = right;

int sum = new Solution().MaxPathSum(root);
Console.WriteLine(sum);
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {

    private int totalSum = int.MinValue;

    public int MaxPathSum(TreeNode root)
    {
        DephFirstSearch(root);
        return totalSum;
    }

    private int DephFirstSearch(TreeNode root) {
        if (root == null) return 0;

        int rightSum = Math.Max(0, DephFirstSearch(root.right));
        int leftSum = Math.Max(0, DephFirstSearch(root.left));

        totalSum = Math.Max(totalSum, leftSum + rightSum + root.val);

        return root.val + Math.Max(leftSum, rightSum);

    }


}