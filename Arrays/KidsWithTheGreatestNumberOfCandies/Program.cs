// Problem 1431. Kids With the Greatest Number of Candies
// Link https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] candies = { 2, 3, 5, 1, 3 };
      int extraCandies = 3;
      List<bool> output = KidsWithCandies(candies, extraCandies);
      Console.WriteLine(string.Join(',', output));
   }
   static List<bool> KidsWithCandies(int[] candies, int extraCandies)
   {
      int max = 0;
      List<bool> output = new List<bool>();

      foreach (int candy in candies)
      {
         if (candy > max)
         {
            max = candy;
         }
      }

      foreach (int candy in candies)
      {
         if (candy + extraCandies >= max)
         {
            output.Add(true);
         }
         else
         {
            output.Add(false);
         }
      }

      return output;
   }
}

