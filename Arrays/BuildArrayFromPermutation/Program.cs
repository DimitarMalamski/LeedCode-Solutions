// Problem 1920. Build Array from Permutation
// Link https://leetcode.com/problems/build-array-from-permutation/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 0, 2, 1, 5, 3, 4 };
      int[] output = BuildArray(nums);
      Console.WriteLine(string.Join(", ", output));
   }
   static int[] BuildArray(int[] nums)
   {
      int n = nums.Length;
      int[] ans = new int[n];

      for (int i = 0; i < n; i++)
      {
         ans[i] = nums[nums[i]];
      }

      return ans;
   }
}
