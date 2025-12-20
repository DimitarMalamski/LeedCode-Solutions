// Problem 3289. The Two Sneaky Numbers of Digitville
// Link https://leetcode.com/problems/the-two-sneaky-numbers-of-digitville/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 0, 1, 1, 0 };
      int[] output = GetSneakyNumbers(nums);
      Console.WriteLine(string.Join(", ", output));
   }
   static int[] GetSneakyNumbers(int[] nums)
   {
      int n = nums.Length - 2;
      int[] count = new int[n];
      List<int> result = new List<int>();

      foreach (int num in nums)
      {
         count[num]++;
         if (count[num] == 2)
         {
            result.Add(num);
         }
      }

      return result.ToArray();
   }
}
