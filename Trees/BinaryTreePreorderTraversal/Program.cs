// Problem 144. Binary Tree Preorder Traversal
// Link https://leetcode.com/problems/binary-tree-preorder-traversal/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      Solution sol = new Solution();
      TreeNode root = new TreeNode(1);
      root.right = new TreeNode(2);
      root.right.left = new TreeNode(3);

      List<int> output = (List<int>)sol.PreorderTraversal(root);
      Console.WriteLine(string.Join(", ", output));
   }

   public IList<int> PreorderTraversal(TreeNode root)
   {
      List<int> result = new List<int>();
      Preorder(root, result);
      return result;
   }

   public void Preorder(TreeNode node, IList<int> result)
   {
      if (node == null) return;

      result.Add(node.val);
      Preorder(node.left, result);
      Preorder(node.right, result);
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
