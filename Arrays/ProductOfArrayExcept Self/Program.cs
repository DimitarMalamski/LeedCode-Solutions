// Problem 238. Product of Array Except Self
// Link https://leetcode.com/problems/product-of-array-except-self/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Medium
class Solution
{
   static void Main(string[] args)
   {
      int[] input = { 1, 2, 3, 4 };
      int[] output = ProductExceptSelf(input);
      Console.WriteLine(string.Join(',', output));
   }
   static int[] ProductExceptSelf(int[] nums)
   {
      int n = nums.Length;
      int[] ans = new int[n];

      ans[0] = 1;
      for (int i = 1; i < n; i++)
      {
         ans[i] = ans[i - 1] * nums[i - 1];
      }

      int suffix = 1;
      for (int i = n - 1; i >= 0; i--)
      {
         ans[i] *= suffix;
         suffix *= nums[i];
      }

      return ans;
   } 
}
