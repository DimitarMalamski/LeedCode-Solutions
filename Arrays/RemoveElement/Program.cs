// Problem 27. Remove Element
// Link https://leetcode.com/problems/remove-element/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 3, 2, 2, 3 };
      int val = 3;
      int output = RemoveElement(nums, val);
      Console.WriteLine(output);
   }
   static int RemoveElement(int[] nums, int val)
   {
      int write = 0;

      for (int read = 0; read < nums.Length; read++)
      {
         if (nums[read] != val)
         {
            nums[write] = nums[read];
            write++;
         }
      }

      return write;
   }
}
