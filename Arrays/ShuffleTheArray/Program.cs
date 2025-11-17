// Problem Q2. Shuffle the Array
// Link https://leetcode.com/problems/shuffle-the-array/?envType=problem-list-v2&envId=dsa-linear-shoal-array-i
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 2, 5, 1, 3, 4, 7 };
      int n = 3;
      int[] output = Shuffle(nums, n);
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
}
