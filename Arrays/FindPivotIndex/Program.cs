// Problem 724. Find Pivot Index
// Link https://leetcode.com/problems/find-pivot-index/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 2, 1, -1 };
      int output = PivotIndex(nums);
      Console.WriteLine(output);
   }
   static int PivotIndex(int[] nums)
   {
      int index = 0;

      while (index != nums.Length)
      {
         int leftSum = 0;
         int rightSum = 0;

         for (int i = 0; i < index; i++)
         {
            leftSum += nums[i];
         }

         for (int i = index + 1; i < nums.Length; i++)
         {
            rightSum += nums[i];
         }

         if (leftSum == rightSum) return index;

         index++;
      }

      return -1;
   }

   static int PivotIndexOptimized(int[] nums)
   {
      int totalSum = 0;
      foreach (int num in nums)
      {
         totalSum += num;
      }

      int leftSum = 0;
      for (int i = 0; i < nums.Length; i++)
      {
         int rightSum = totalSum - leftSum - nums[i];
         if (leftSum == rightSum) return i;
         leftSum += nums[i];
      }

      return -1;
   }
}
