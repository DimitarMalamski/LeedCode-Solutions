// Problem 1512. Number of Good Pairs
// Link https://leetcode.com/problems/number-of-good-pairs/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 1, 2, 3, 1, 1, 3 };
      int output = NumIdenticalPairs(nums);
      Console.WriteLine(output);
   }
   static int NumIdenticalPairs(int[] nums)
   {
      Dictionary<int, int> freq = new Dictionary<int, int>();
      int result = 0;

      foreach (int num in nums)
      {
         if (freq.ContainsKey(num))
         {
            result += freq[num];
            freq[num]++;
         }
         else
         {
            freq[num] = 1;
         }
      }

      return result;
   }
}
