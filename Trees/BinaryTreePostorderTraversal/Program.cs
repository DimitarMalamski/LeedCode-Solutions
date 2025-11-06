// Problem 145. Binary Tree Postorder Traversal
// Link https://leetcode.com/problems/binary-tree-postorder-traversal/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      Solution sol = new Solution();
      TreeNode root = new TreeNode(1);
      root.right = new TreeNode(2);
      root.right.left = new TreeNode(3);

      List<int> output = (List<int>)sol.PostorderTraversal(root);
      Console.WriteLine(string.Join(", ", output));
   }

   public IList<int> PostorderTraversal(TreeNode root)
   {
      List<int> result = new List<int>();
      Postorder(root, result);
      return result;
   }
   public void Postorder(TreeNode node, List<int> result)
   {
      if (node == null) return;

      Postorder(node.left, result);
      Postorder(node.right, result);
      result.Add(node.val);
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
