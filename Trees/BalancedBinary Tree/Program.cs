// Problem 110. Balanced Binary Tree
// https://leetcode.com/problems/balanced-binary-tree/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      TreeNode root = new TreeNode(3,
         new TreeNode(9),
         new TreeNode(20, new TreeNode(15), new TreeNode(7))
      );

      Solution sol = new Solution();
      bool output = sol.IsBalanced(root);

      Console.WriteLine(output);
   }

   public bool IsBalanced(TreeNode root)
   {
      return Check(root).IsBalanced; 
   }

   private Result Check(TreeNode node)
   {
      if (node == null) return new Result(true, 0);

      Result left = Check(node.left);
      Result right = Check(node.right);


      if (!left.IsBalanced || !right.IsBalanced)
      {
         return new Result(false, 0);
      }

      if (Math.Abs(left.Height - right.Height) > 1)
      {
         return new Result(false, 0);
      }

      int currentHeight = Math.Max(left.Height, right.Height) + 1;
      return new Result(true, currentHeight);
   }

   private class Result
   {
      public bool IsBalanced { get; }
      public int Height { get; }

      public Result(bool isBalanced, int height)
      {
         IsBalanced = isBalanced;
         Height = height;
      }
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
