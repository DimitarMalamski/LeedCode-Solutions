// Problem 1221. Split a String in Balanced Strings
// Link https://leetcode.com/problems/split-a-string-in-balanced-strings/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string s = "RLRRLLRLRL";
      int output = BalancedStringSplit(s);
      Console.WriteLine(output);
   }
   static int BalancedStringSplit(string s)
   {
      int counter = 0;
      int result = 0;

      foreach (char letter in s)
      {
         switch (letter)
         {
            case 'R':
               counter++;
               break;
            case 'L':
               counter--;
               break;
         }

         if (counter == 0) result++;
      }

      return result;
   }
}
