// Problem 896. Monotonic Array
// Link https://leetcode.com/problems/monotonic-array/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 1, 2, 4, 3 };
      bool output = IsMonotonic(nums);
      Console.WriteLine(output);
   }
   static bool IsMonotonic(int[] nums)
   {
      bool up = true;
      bool down = true;

      for (int i = 1; i < nums.Length; i++)
      {
         if (nums[i] > nums[i - 1]) down = false;
         if (nums[i] < nums[i - 1]) up = false;
      }

      return up || down;
   }
   static bool IsMonotonicOptimized(int[] nums)
   {
      bool up = true;
      bool down = true;

      for (int i = 1; i < nums.Length; i++)
      {
         if (nums[i] > nums[i - 1]) down = false;
         if (nums[i] < nums[i - 1]) up = false;

         if (!down && !up)
         {
            return false;
         }
      }

      return true;
   }
}
