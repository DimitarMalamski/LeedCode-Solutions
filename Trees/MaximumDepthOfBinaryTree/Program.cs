// Problem 104. Maximum Depth of Binary Tree
// Link https://leetcode.com/problems/maximum-depth-of-binary-tree/description/
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

      int output = sol.MaxDepth(root);
      Console.WriteLine(output); 
   }
   public int MaxDepth(TreeNode root)
   {
      if (root == null) return 0;

      int leftDepth = MaxDepth(root.left);
      int rightDepth = MaxDepth(root.right);

      return Math.Max(leftDepth, rightDepth) + 1;
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

