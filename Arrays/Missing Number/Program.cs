// Problem 268. Missing Number
// Link https://leetcode.com/problems/missing-number/description/?envType=problem-list-v2&envId=array
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] input = { 0, 1 };
      int output = MissingNumberOptimized(input);
      Console.WriteLine(output);
   }
   static int MissingNumber(int[] nums)
   {
      Array.Sort(nums);

      if (nums[0] != 0)
      {
         return 0;
      }

      for (int i = 0; i < nums.Length - 1; i++)
      {
         if (nums[i] + 1 != nums[i + 1])
         {
            return nums[i] += 1;
         }
      }

      return nums.Length;
   }
   static int MissingNumberOptimized(int[] nums)
   {
      int expectedSum = nums.Length * (nums.Length + 1) / 2;
      int actualSum = 0;

      foreach (int num in nums)
      {
         actualSum += num;
      }

      return expectedSum - actualSum;
   }
}
