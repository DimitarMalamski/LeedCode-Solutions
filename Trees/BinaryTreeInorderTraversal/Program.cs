// Problem 94. Binary Tree Inorder Traversal
// Link https://leetcode.com/problems/binary-tree-inorder-traversal/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      Solution sol = new Solution();

      TreeNode root = new TreeNode(1);
      root.right = new TreeNode(2);
      root.right.left = new TreeNode(3);

      IList<int> output = sol.InorderTraversal(root);
      Console.WriteLine(string.Join(", ", output));
   }

   public IList<int> InorderTraversal(TreeNode root)
   {
      List<int> result = new List<int>();
      Traverse(root, result);
      return result;
   }
   private void Traverse(TreeNode node, List<int> result)
   {
      if (node == null)
      {
         return;
      }

      Traverse(node.left, result);
      result.Add(node.val);
      Traverse(node.right, result);
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