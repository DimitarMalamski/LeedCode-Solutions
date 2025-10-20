// Problem 976. Largest Perimeter Triangle
// Link https://leetcode.com/problems/largest-perimeter-triangle/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 2, 1, 2 };
      int output = LargestPerimeter(nums);
      Console.WriteLine(output);
   }
   static int LargestPerimeter(int[] nums)
   {
      Array.Sort(nums);
      Array.Reverse(nums);

      for (int i = 0; i < nums.Length - 2; i++)
      {
         if (nums[i + 1] + nums[i + 2] > nums[i])
         {
            return nums[i] + nums[i + 1] + nums[i + 2];
         }
      }

      return 0;
   }
   static int LargestPerimeterOptimized(int[] nums)
   {
      Array.Sort(nums);

      for (int i = nums.Length - 3; i >= 0; i--)
      {
         if (nums[i] + nums[i + 1] > nums[i + 2])
         {
            return nums[i] + nums[i + 1] + nums[i + 2];
         }
      }

      return 0;
   }
}
