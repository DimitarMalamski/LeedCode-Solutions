// Problem 389. Find the Difference
// Link https://leetcode.com/problems/find-the-difference/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string s = "abcd";
      string t = "abcde";
      char output = FindTheDifferenceXOR(s, t);
      Console.WriteLine(output);
   }
   static char FindTheDifference(string s, string t)
   {
      int[] set = new int[26];

      foreach (char c in s)
      {
         set[c - 'a']++;
      }

      foreach (char c in t)
      {
         if (--set[c - 'a'] < 0) return c;
      }

      return ' ';
   }

   static char FindTheDifferenceXOR(string s, string t)
   {
      int result = 0;
      foreach (char c in s) result ^= c;
      foreach (char c in t) result ^= c;
      return (char)result;      
   }
}
