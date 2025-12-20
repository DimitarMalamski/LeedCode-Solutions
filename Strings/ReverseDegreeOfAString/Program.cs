// Problem 3498. Reverse Degree of a String
// Link https://leetcode.com/problems/reverse-degree-of-a-string/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string s = "zaza";
      int output = ReverseDegree(s);
      Console.WriteLine(output);
   }
   static int ReverseDegree(string s)
   {
      int sum = 0;

      for (int i = 0; i < s.Length; i++)
      {
         int reverse = 'z' - s[i] + 1;
         int stringPos = i + 1;

         sum += reverse * stringPos;
      }

      return sum;
   }
}
