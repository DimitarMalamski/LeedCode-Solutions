// Problem 3162. Find the Number of Good Pairs I
// Link https://leetcode.com/problems/find-the-number-of-good-pairs-i/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums1 = { 1, 3, 4 };
      int[] nums2 = { 1, 3, 4 };
      int k = 1;
      int output = NumberOfPairs(nums1, nums2, k);
      Console.WriteLine(output);
   }
   static int NumberOfPairs(int[] nums1, int[] nums2, int k)
   {
      int n = nums1.Length;
      int m = nums2.Length;

      int count = 0;

      for (int i = 0; i < n; i++)
      {
         for (int j = 0; j < m; j++)
         {
            if (nums1[i] % (nums2[j] * k) == 0) count++;
         }
      }

      return count;
   }
}
