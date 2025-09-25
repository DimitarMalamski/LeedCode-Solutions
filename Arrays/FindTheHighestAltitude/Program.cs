// Problem 1732. Find the Highest Altitude
// Link https://leetcode.com/problems/find-the-highest-altitude/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] gain = { -5, 1, 5, 0, -7 };
      int output = LargestAltitude(gain);
      Console.WriteLine(output);
   }
   static int LargestAltitude(int[] gain)
   {
      int max = 0;
      int prefix = 0;

      foreach (int item in gain)
      {
         prefix += item;
         if (prefix > max) max = prefix;
      }

      return max;
   }
}
