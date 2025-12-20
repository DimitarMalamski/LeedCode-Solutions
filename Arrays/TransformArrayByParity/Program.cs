// Problem 3467. Transform Array by Parity
// Link https://leetcode.com/problems/transform-array-by-parity/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 4, 3, 2, 1 };
      int[] output = TransformArray(nums);
      Console.WriteLine(string.Join(",", output));
   }
   static int[] TransformArray(int[] nums)
   {
      int n = nums.Length;
      int[] result = new int[n];

      for (int i = 0; i < n; i++)
      {
         if (nums[i] % 2 == 0)
         {
            result[i] = 0;
         }
         else
         {
            result[i] = 1;
         }
      }

      Array.Sort(result);

      return result;
   }
}