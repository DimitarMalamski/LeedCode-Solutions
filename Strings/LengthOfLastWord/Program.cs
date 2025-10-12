// Problem 58. Length of Last Word
// Link https://leetcode.com/problems/length-of-last-word/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string s = "Hello World";
      int length = LengthOfLastWord(s);
      Console.WriteLine(length);
   }
   static int LengthOfLastWord(string s)
   {
      int length = 0;

      int pointer = s.Length - 1;

      while (pointer >= 0 && s[pointer] == ' ')
      {
         pointer--;
      }

      while (pointer >= 0 && s[pointer] != ' ')
      {
         length++;
         pointer--;
      }

      return length;
   }
}
