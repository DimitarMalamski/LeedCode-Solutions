// Problem 1523. Count Odd Numbers in an Interval Range
// Link https://leetcode.com/problems/count-odd-numbers-in-an-interval-range/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int low = 3;
      int high = 7;
      int count = CountOdds(low, high);
      Console.WriteLine(count);
   }
   static int CountOdds(int low, int high)
   {
      int count = 0;
      for (int i = low; i <= high; i++)
      {
         if (i % 2 != 0) count++;
      }

      return count;
   }
   static int CountOddsOptimized(int low, int high)
   {
      return (high + 1) / 2 - (low / 2);
   }

}
