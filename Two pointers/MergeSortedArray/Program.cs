// Problem 88. Merge Sorted Array
// Link https://leetcode.com/problems/merge-sorted-array/description/?envType=study-plan-v2&envId=top-interview-150
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      int[] nums1 = { 1, 2, 3, 0, 0, 0 };
      int m = 3;
      int[] nums2 = { 2, 5, 6 };
      int n = 3;

      Merge(nums1, m, nums2, n);

      Console.WriteLine(string.Join(" ", nums1));
   }
   public static void Merge(int[] nums1, int m, int[] nums2, int n)
   {
      int i = m - 1;
      int j = n - 1;
      int k = m + n - 1;

      while (i >= 0 && j >= 0)
      {
         if (nums1[i] > nums2[j])
         {
            nums1[k--] = nums1[i--];
         }
         else
         {
            nums1[k--] = nums2[j--];
         }
      }

      while (j >= 0)
      {
         nums1[k--] = nums2[j--];
      }
   }
}
