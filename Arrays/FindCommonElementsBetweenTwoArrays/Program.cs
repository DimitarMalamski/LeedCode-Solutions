// Problem 2956. Find Common Elements Between Two Arrays
// Link https://leetcode.com/problems/find-common-elements-between-two-arrays/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums1 = { 2, 3, 2 };
      int[] nums2 = { 1, 2 };
      int[] output = FindIntersectionValues(nums1, nums2);
      Console.WriteLine(string.Join(", ", output));
   }
   static int[] FindIntersectionValues(int[] nums1, int[] nums2)
   {
      int n = nums1.Length;
      int m = nums2.Length;

      int count1 = 0;
      int count2 = 0;

      for (int i = 0; i < n; i++)
      {
         for (int j = 0; j < m; j++)
         {
            if (nums1[i] == nums2[j])
            {
               count1++;
               break;
            }
         }
      }

      for (int i = 0; i < m; i++)
      {
         for (int j = 0; j < n; j++)
         {
            if (nums2[i] == nums1[j])
            {
               count2++;
               break;
            }
         }
      }

      return new int[] { count1, count2 };
   }
}
