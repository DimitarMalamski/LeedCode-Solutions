// Problem 151. Reverse Words in a String
// Link https://leetcode.com/problems/reverse-words-in-a-string/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Medium
class Solution
{
   static void Main(string[] args)
   {
      string s = "the sky is blue";
      string output = ReverseWordsOptimized(s);
      Console.WriteLine(output);
   }
   static string ReverseWords(string s)
   {
      var parts = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

      Array.Reverse(parts);

      return string.Join(' ', parts);
   }
   static string ReverseWordsOptimized(string s)
   {
      List<string> result = new List<string>();

      int i = 0, n = s.Length;

      while (i < n)
      {
         while (i < n && s[i] == ' ') i++;

         if (i >= n) break;

         int start = i;

         while (i < n && s[i] != ' ') i++;

         result.Add(s.Substring(start, i - start));
      }

      result.Reverse();

      return string.Join(' ', result);
   }
}



