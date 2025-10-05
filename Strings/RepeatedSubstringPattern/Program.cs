// Problem 459. Repeated Substring Pattern
// Link https://leetcode.com/problems/repeated-substring-pattern/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string s = "abab";
      bool output = RepeatedSubstringPattern(s);
      Console.WriteLine(output);
   }

   static bool RepeatedSubstringPattern(string s)
   {
      string check = s + s;
      string trimmed = check.Substring(1, check.Length - 2);
      return trimmed.Contains(s);
   }
}
