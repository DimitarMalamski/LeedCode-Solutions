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
      q.right = new TreeNode(3);

      bool output = sol.IsSameTreeQueue(p, q);
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

   public bool IsSameTreeQueue(TreeNode p, TreeNode q)
   {
      if (p == null && q == null)
         return true;
      if (p == null || q == null)
         return false;

      Queue<TreeNode> queueP = new Queue<TreeNode>();
      Queue<TreeNode> queueQ = new Queue<TreeNode>();

      queueP.Enqueue(p);
      queueQ.Enqueue(q);

      while (queueP.Count > 0 && queueQ.Count > 0)
      {
         TreeNode nodeP = queueP.Dequeue();
         TreeNode nodeQ = queueQ.Dequeue();

         if (nodeP.val != nodeQ.val)
         {
            return false;
         }

         if ((nodeP.left == null) != (nodeQ.left == null)) return false;

         if (nodeP.left != null)
         {
            queueP.Enqueue(nodeP.left);
            queueQ.Enqueue(nodeQ.left!);
         }

         if ((nodeP.right == null) != (nodeQ.right == null)) return false;

         if (nodeP.right != null)
         {
            queueP.Enqueue(nodeP.right);
            queueQ.Enqueue(nodeQ.right!);
         }
      }

      return queueP.Count == queueQ.Count;
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
