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

      int output = sol.MaxDepthBFS(root);
      Console.WriteLine(output); 
   }
   public int MaxDepth(TreeNode root)
   {
      if (root == null) return 0;

      int leftDepth = MaxDepth(root.left);
      int rightDepth = MaxDepth(root.right);

      return Math.Max(leftDepth, rightDepth) + 1;
   }

   public int MaxDepthBFS(TreeNode root)
   {
      if (root == null) return 0;

      Queue<TreeNode> queue = new Queue<TreeNode>();
      queue.Enqueue(root);
      int depth = 0;

      while (queue.Count > 0)
      {
         int size = queue.Count;
         for (int i = 0; i < size; i++)
         {
            TreeNode node = queue.Dequeue();
            if (node.left != null) queue.Enqueue(node.left);
            if (node.right != null) queue.Enqueue(node.right);
         }

         depth++;
      }

      return depth;  
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

