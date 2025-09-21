// Problem 334. Increasing Triplet Subsequence
// Link https://leetcode.com/problems/increasing-triplet-subsequence/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Medium
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 1, 2, 3, 4, 5 };
      bool output = IncreasingTriplet(nums);
      Console.WriteLine(output);
   }
   static bool IncreasingTriplet(int[] nums)
   {
      long first = long.MaxValue;
      long second = long.MaxValue;

      foreach (int x in nums)
      {
         if (x <= first)
         {
            first = x;
         }
         else if (x <= second)
         {
            second = x;
         }
         else
         {
            return true;
         }
      }

      return false;
   }
}
