// Problem 3512. Minimum Operations to Make Array Sum Divisible by K
// Link https://leetcode.com/problems/minimum-operations-to-make-array-sum-divisible-by-k/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 4,1,3 };
      int k = 4;
      int output = MinOperations(nums, k);
      Console.WriteLine(output);
   }
   static int MinOperations(int[] nums, int k)
   {
      int sum = 0;

      foreach(int num in nums) {
         sum += num;
      }

      return sum % k;
   }
}
