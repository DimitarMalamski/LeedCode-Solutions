// Problem 14. Longest Common Prefix
// Link https://leetcode.com/problems/longest-common-prefix/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string[] input = { "flower", "flow", "flight" };
      string output = SolutionTwo(input);
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

   static string SolutionTwo(string[] input)
   {
      if (input == null || input.Length == 0)
      {
         return string.Empty;
      }

      int min = 0;

      for (int i = 1; i < input.Length; i++)
      {
         if (input[i].Length < input[min].Length)
         {
            min = i;
         }
      }

      string shortest = input[min];

      for (int i = 0; i < shortest.Length; i++)
      {
         for (int j = 0; j < input.Length; j++)
         {
            if (input[j][i] != shortest[i])
            {
               return shortest.Substring(0, i);
            }
         }
      }

      return shortest;
   }
}
