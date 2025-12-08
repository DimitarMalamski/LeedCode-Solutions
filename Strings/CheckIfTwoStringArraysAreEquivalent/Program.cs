// Problem 1662. Check If Two String Arrays are Equivalent
// Link https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string[] word1 = { "ab", "c" };
      string[] word2 = { "a", "bc" };
      bool output = ArrayStringsAreEqual(word1, word2);
      Console.WriteLine(output);
   }
   static bool ArrayStringsAreEqual(string[] word1, string[] word2)
   {
      string result1 = "";
      string result2 = "";

      foreach (string word in word1)
      {
         result1 += word;
      }

      foreach (string word in word2)
      {
         result2 += word;
      }

      return result1 == result2;
   }
}
