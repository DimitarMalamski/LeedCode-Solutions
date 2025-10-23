// Problem 3110. Score of a String
// Link https://leetcode.com/problems/score-of-a-string/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string s = "hello";
      int output = ScoreOfString(s);
      Console.WriteLine(output);
   }
   static int ScoreOfString(string s)
   {
      int sum = 0;
      char[] chars = s.ToCharArray();

      for (int i = 1; i < chars.Length; i++)
      {
         int val = Math.Abs(chars[i] - chars[i - 1]);
         sum += val;
      }

      return sum;
   }
}
