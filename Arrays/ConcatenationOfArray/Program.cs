// Problem Q1. Concatenation of Array
// Link https://leetcode.com/problems/concatenation-of-array/description/?envType=problem-list-v2&envId=dsa-linear-shoal-array-i
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 1, 2, 1 };
      int[] output = GetConcatenation(nums);
      Console.WriteLine(string.Join(", ", output));
   }
   static int[] GetConcatenation(int[] nums)
   {
      int n = nums.Length;
      int[] result = new int[2 * n];

      for (int i = 0; i < n; i++)
      {
         result[i] = nums[i];
         result[i + n] = nums[i];
      }

      return result;
   }
}
