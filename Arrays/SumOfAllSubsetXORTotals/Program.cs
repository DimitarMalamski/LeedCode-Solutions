// Problem 1863. Sum of All Subset XOR Totals
// Link https://leetcode.com/problems/sum-of-all-subset-xor-totals/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 1, 3 };
      int output = SubsetXORSum(nums);
      Console.WriteLine(output);
   }
   static int SubsetXORSum(int[] nums)
   {
      int or = 0;

      foreach (int num in nums)
      {
         or |= num;
      }

      return or * (1 << (nums.Length - 1));
   }
}
