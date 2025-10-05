// Problem 28. Find the Index of the First Occurrence in a String
// Link https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string haystack = "sadbutsad";
      string needle = "sad";
      int output = StrStr(haystack, needle);
      Console.WriteLine(output);
   }
   static int StrStr(string haystack, string needle)
   {
      if (needle.Length == 0) return 0;

      for (int i = 0; i <= haystack.Length - needle.Length; i++)
      {
         int j = 0;
         while (j < needle.Length && haystack[i + j] == needle[j])
         {
            j++;
         }

         if (j == needle.Length)
         {
            return i;
         }
      }

      return -1;
   }

}
