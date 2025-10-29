// Problem 101. Symmetric Tree
// Link https://leetcode.com/problems/same-tree/description 
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      Solution sol = new Solution();

      TreeNode root = new TreeNode(1);
      root.left = new TreeNode(2);
      root.right = new TreeNode(2);

      root.left.left = new TreeNode(3);
      root.left.right = new TreeNode(4);

      root.right.left = new TreeNode(4);
      root.right.right = new TreeNode(3);

      bool output = sol.IsSymmetricSolutionTwo(root);
      Console.WriteLine(output);
   }

   public bool IsSymmetric(TreeNode root)
   {
      if (root == null) return true;
      return IsMirror(root.left, root.right);
   }

   private bool IsMirror(TreeNode t1, TreeNode t2)
   {
      if (t1 == null && t2 == null) return true;
      if (t1 == null || t2 == null) return false;

      return (t1.val == t2.val)
         && IsMirror(t1.left, t2.right)
         && IsMirror(t1.right, t2.left);
   }

   public bool IsSymmetricSolutionTwo(TreeNode root)
   {
      if (root == null) return true;

      Queue<TreeNode> q = new Queue<TreeNode>();
      q.Enqueue(root.left);
      q.Enqueue(root.right);

      while (q.Count > 0)
      {
         TreeNode t1 = q.Dequeue();
         TreeNode t2 = q.Dequeue();

         if (t1 == null && t2 == null) continue;
         if (t1 == null || t2 == null || t1.val != t2.val) return false;

         q.Enqueue(t1.left);
         q.Enqueue(t2.right);
         q.Enqueue(t1.right);
         q.Enqueue(t2.left);
      }

      return true;
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