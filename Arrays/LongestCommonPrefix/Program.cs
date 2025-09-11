// Problem 14. Longest Common Prefix
// Link https://leetcode.com/problems/longest-common-prefix/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string[] input = { "flower", "flow", "flight" };
      string output = SolutionOne(input);
      Console.WriteLine(output);
   }
   static string SolutionOne(string[] input)
   {
      string prexif = "";

      int shortestLength = input.Min(x => x.Length);
      string shortest = input.FirstOrDefault(x => x.Length == shortestLength);

      for (int i = 0; i < shortestLength; i++)
      {
         foreach (string word in input)
         {
            if (i == word.Length || word[i] != shortest[i])
            {
               return prexif;
            }
         }
         prexif += shortest[i];
      }

      return prexif;
   }
}
