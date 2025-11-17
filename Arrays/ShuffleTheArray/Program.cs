// Problem Q2. Shuffle the Array
// Link https://leetcode.com/problems/shuffle-the-array/?envType=problem-list-v2&envId=dsa-linear-shoal-array-i
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 2, 5, 1, 3, 4, 7 };
      int n = 3;
      int[] output = ShuffleOptimized(nums, n);
      Console.WriteLine(string.Join(", ", output));
   }
   static int[] Shuffle(int[] nums, int n)
   {
      int l = nums.Length;
      int[] result = new int[l];

      for (int i = 0; i < l; i++)
      {
         if (i % 2 == 0)
         {
            result[i] = nums[i / 2];
         }
         else
         {
            result[i] = nums[n + (i / 2)];
         }
      }

      return result;
   }

   static int[] ShuffleOptimized(int[] nums, int n)
   {
      int[] result = new int[2 * n];

      for (int i = 0; i < n; i++)
      {
         result[2 * i] = nums[i];
         result[2 * i + 1] = nums[n + i];
      }

      return result;
   }
}
