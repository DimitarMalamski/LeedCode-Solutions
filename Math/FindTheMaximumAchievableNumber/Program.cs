// Problem 2769. Find the Maximum Achievable Number
// Link https://leetcode.com/problems/find-the-maximum-achievable-number/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int num = 4;
      int t = 1;
      int output = TheMaximumAchievableX(num, t);
      Console.WriteLine(output);
   }

   static int TheMaximumAchievableX(int num, int t)
   {
      return num + 2 * t;
   }
}
