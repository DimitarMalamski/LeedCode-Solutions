// Problem 111. Minimum Depth of Binary Tree
// Link https://leetcode.com/problems/minimum-depth-of-binary-tree/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      Solution sol = new Solution();

      TreeNode root = new TreeNode(3);
      root.left = new TreeNode(9);
      root.right = new TreeNode(20);
      root.right.left = new TreeNode(15);
      root.right.right = new TreeNode(7);

      int result = sol.MinDepth(root);
      Console.WriteLine(result);
   }

   public int MinDepth(TreeNode root)
   {
      if (root == null) return 0;

      if (root.left == null)
      {
         return 1 + MinDepth(root.right);
      }

      if (root.right == null)
      {
         return 1 + MinDepth(root.left);
      }

      return 1 + Math.Min(MinDepth(root.left), MinDepth(root.right));
   }
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
}
