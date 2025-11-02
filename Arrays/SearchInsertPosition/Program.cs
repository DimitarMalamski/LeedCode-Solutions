// Problem 35. Search Insert Position
// Link https://leetcode.com/problems/search-insert-position/description/?envType=problem-list-v2&envId=binary-search
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 1, 3, 5, 6 };
      int target = 5;
      int output = SearchInsert(nums, target);
      Console.WriteLine(output);
   }
   static int SearchInsert(int[] nums, int target)
   {
      int left = 0;
      int right = nums.Length - 1;

      while (left <= right)
      {
         int mid = (left + right) / 2;

         if (nums[mid] == target)
         {
            return mid;
         }
         else if (target < nums[mid])
         {
            right = mid - 1;
         }
         else
         {
            left = mid + 1;
         }
      }

      return left;
   }
}