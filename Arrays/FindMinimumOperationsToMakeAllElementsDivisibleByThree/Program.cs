// Problem 3190. Find Minimum Operations to Make All Elements Divisible by Three
// Link https://leetcode.com/problems/find-minimum-operations-to-make-all-elements-divisible-by-three/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 1, 2, 3, 4 };
      int output = MinimumOperations(nums);
      Console.WriteLine(output);
   }
   static int MinimumOperations(int[] nums)
   {
      int count = 0;

      foreach (int num in nums)
      {
         if (num % 3 != 0) count++;
      }

      return count;
   }
}
