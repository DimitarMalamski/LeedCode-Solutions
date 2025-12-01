// Problem 2114. Maximum Number of Words Found in Sentences
// Link https://leetcode.com/problems/maximum-number-of-words-found-in-sentences/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string[] sentences = { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
      int output = MostWordsFound(sentences);
      Console.WriteLine(output);
   }
   static int MostWordsFound(string[] sentences)
   {
      int max = 0;

      foreach (string sentence in sentences)
      {
         int count = 1;

         foreach (char letter in sentence)
         {
            if (Char.IsWhiteSpace(letter)) count++;
         }

         if (max <= count) max = count;
      }

      return max;
   }
}