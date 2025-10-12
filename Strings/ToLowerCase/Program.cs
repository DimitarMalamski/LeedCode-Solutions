// Problem 709. To Lower Case
// Link https://leetcode.com/problems/to-lower-case/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string s = "Hello";
      string output = ToLowerCase(s);
      Console.WriteLine(output);
   }
   static string ToLowerCase(string s)
   {
      char[] chars = s.ToCharArray();

      for (int i = 0; i < chars.Length; i++)
      {
         if (chars[i] >= 'A' && chars[i] <= 'Z')
         {
            chars[i] = (char)(chars[i] + 32);
         }
      }

      return new string(chars);
   }
}
