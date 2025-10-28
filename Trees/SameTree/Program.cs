// Problem 100. Same Tree
// Link https://leetcode.com/problems/same-tree/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      Solution sol = new Solution();

      TreeNode p = new TreeNode(1);
      p.left = new TreeNode(2);
      p.right = new TreeNode(3);

      TreeNode q = new TreeNode(1);
      q.left = new TreeNode(2);
      q.right = new TreeNode(4);

      bool output = sol.IsSameTree(p, q);
      Console.WriteLine(output);
   }
   public bool IsSameTree(TreeNode p, TreeNode q)
   {
      if (p == null && q == null)
      {
         return true;
      }

      if (p == null || q == null)
      {
         return false;
      }

      if (p.val != q.val)
      {
         return false;
      }

      return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
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
