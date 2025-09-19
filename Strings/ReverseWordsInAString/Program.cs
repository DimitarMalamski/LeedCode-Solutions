// Problem 151. Reverse Words in a String
// Link https://leetcode.com/problems/reverse-words-in-a-string/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Medium
class Solution
{
   static void Main(string[] args)
   {
      string s = "the sky is blue";
      string output = ReverseWords(s);
      Console.WriteLine(output);
   }
   static string ReverseWords(string s)
   {
      var parts = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);

      Array.Reverse(parts);

      return string.Join(' ', parts);
   } 
}



