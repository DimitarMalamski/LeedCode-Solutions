// Problem 125. Valid Palindrome
// Link https://leetcode.com/problems/valid-palindrome/description/
// Difficulty: Easy

using System;
using System.Linq;
class Solution
{
   static void Main(string[] args)
   {
      string input = "Was it a car or a cat I saw?";
      bool output = Check(input);
      Console.WriteLine(output);
   }
   static bool Check(string input)
   {
      string filtered = new string(input.Where(char.IsLetterOrDigit)
                                       .Select(char.ToLowerInvariant)
                                       .ToArray());

      for (int i = 0; i < filtered.Length; i++) {
         if (filtered[i] != filtered[(filtered.Length - 1) - i]) {
            return false;
         }
      }

      return true;
   }
}
