// Problem 392. Is Subsequence
// Link https://leetcode.com/problems/is-subsequence/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      string s = "abc";
      string t = "ahbgdc";
      bool output = IsSubsequence(s, t);
      Console.WriteLine(output);
   }

   static bool IsSubsequence(string s, string t)
   {
      int first = 0;
      int second = 0;

      while (first < s.Length && second < t.Length)
      {
         if (s[first] == t[second])
         {
            first++;
            second++;
         }
         else
         {
            second++;
         }
      }

      if (first == s.Length) return true; else return false;
   }

   static bool IsSubsequenceOptimized(string s, string t)
   {
      int first = 0;
      int second = 0;

      while (first < s.Length && second < t.Length)
      {
         if (s.Length - first > t.Length - second) return false;
         
         if (s[first] == t[second])
         {
            first++;
         }

         second++;
      }

      if (first == s.Length) return true; else return false;
   }
}
