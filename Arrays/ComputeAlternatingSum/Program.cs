// Problem 3701. Compute Alternating Sum
// Link https://leetcode.com/problems/compute-alternating-sum/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 1, 3, 5, 7 };
      int output = AlternatingSum(nums);
      Console.WriteLine(output);
   }
   static int AlternatingSum(int[] nums)
   {
      int result = 0;

      for (int i = 0; i < nums.Length; i++)
      {
         if (i % 2 == 0)
         {
            result += nums[i];
         }
         else
         {
            result -= nums[i];
         }
      }

      return result;
   }
}