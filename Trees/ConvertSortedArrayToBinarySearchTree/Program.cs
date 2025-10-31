// Problem 108. Convert Sorted Array to Binary Search Tree
// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      Solution sol = new Solution();
      int[] nums = { -10, -3, 0, 5, 9 };
      TreeNode root = sol.SortedArrayToBST(nums);

      sol.printInOrder(root);
   }

   public TreeNode SortedArrayToBST(int[] nums)
   {
      return build(nums, 0, nums.Length - 1); 
   }

   private TreeNode build(int[] nums, int left, int right)
   {
      if (left > right) return null;

      int mid = left + (right - left) / 2;
      TreeNode root = new TreeNode(nums[mid]);

      root.left = build(nums, left, mid - 1);
      root.right = build(nums, mid + 1, right);

      return root;
   }

   public void printInOrder(TreeNode node)
   {
      if (node == null) return;
      printInOrder(node.left);
      Console.Write(node.val + " ");
      printInOrder(node.right);
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
