// Problem 2574. Left and Right Sum Differences
// Link https://leetcode.com/problems/left-and-right-sum-differences/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 10, 4, 8, 3 };
      int[] output = LeftRightDifference(nums);
      Console.WriteLine(string.Join(", ", output));
   }
   static int[] LeftRightDifference(int[] nums)
   {
      int[] result = new int[nums.Length];

      int total = 0;
      foreach (int num in nums)
      {
         total += num;
      }

      int left = 0;

      for (int i = 0; i < nums.Length; i++)
      {
         int right = total - left - nums[i];
         result[i] = Math.Abs(left - right);
         left += nums[i];
      }

      return result;
   }
}