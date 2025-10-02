// Problem 26. Remove Duplicates from Sorted Array
// Link https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 1, 2, 2 };
      int output = RemoveDuplicates(nums);
      Console.WriteLine(output);
   }
   static int RemoveDuplicates(int[] nums)
   {
      if (nums == null || nums.Length == 0) return 0;

      int i = 0;
      for (int j = 1; j < nums.Length; j++)
      {
         if (nums[i] != nums[i])
         {
            i++;
            nums[i] = nums[j];
         }
      }

      return i + 1;
   }
}
