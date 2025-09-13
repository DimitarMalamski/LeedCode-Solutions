// Problem 268. Missing Number
// Link https://leetcode.com/problems/missing-number/description/?envType=problem-list-v2&envId=array
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] input = { 0, 1 };
      int output = MissingNumber(input);
      Console.WriteLine(output);
   }
   static int MissingNumber(int[] nums)
   {
      Array.Sort(nums);
        
      if (nums[0] != 0) {
         return 0;
      }

      for (int i = 0; i < nums.Length - 1; i++) {
         if (nums[i] + 1 != nums[i + 1]) {
            return nums[i] += 1;
         }
      }

      return nums.Length;
   }
}
