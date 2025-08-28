// Problem 1480. Running Sum of 1d Array
// Link https://leetcode.com/problems/running-sum-of-1d-array/description/
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      int[] nums = [1, 2, 3, 4];
      int[] output = Check(nums);
      Console.WriteLine(string.Join(", ", output));
   }
   static int[] Check(int[] nums)
   {
      int[] result = new int[nums.Length];

      int sum = 0;

      for (int i = 0; i < nums.Length; i++)
      {
         sum += nums[i];
         result[i] = sum;
      }

      return result;
   }
}
