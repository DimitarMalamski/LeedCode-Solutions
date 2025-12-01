// Problem 1684. Count the Number of Consistent Strings
// Link https://leetcode.com/problems/count-the-number-of-consistent-strings/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string allowed = "ab";
      string[] words = { "ad", "bd", "aaab", "baa", "badab" };
      int output = CountConsistentStrings(allowed, words);
      Console.WriteLine(output);
   }
   static int CountConsistentStrings(string allowed, string[] words)
   {
      int count = 0;

      foreach (string word in words)
      {
         bool consistent = true;

         foreach (char c in word)
         {
            if (!allowed.Contains(c))
            {
               consistent = false;
               break;
            }
         }

         if (consistent) count++;
      }

      return count;
   }
}
