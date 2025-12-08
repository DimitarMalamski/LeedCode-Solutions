// Problem 344. Reverse String
// Link https://leetcode.com/problems/reverse-string/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      char[] s = { 'h', 'e', 'l', 'l', 'o' };
      ReverseString(s);
      Console.WriteLine(string.Join(",", s));
   }
   static void ReverseString(char[] s)
   {
      int p1 = 0;
      int p2 = s.Length - 1;

      while (p2 > p1)
      {
         char temp = s[p1];
         s[p1] = s[p2];
         s[p2] = temp;

         p1++;
         p2--;
      }
   }
}
