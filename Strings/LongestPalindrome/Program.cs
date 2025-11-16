// Problem 409. Longest Palindrome
// Link https://leetcode.com/problems/longest-palindrome/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string s = "abccccdd";
      int output = LongestPalindrome(s);
      Console.WriteLine(output);
   }
   static int LongestPalindrome(string s)
   {
      Dictionary<char, int> map = new Dictionary<char, int>();

      foreach (char c in s)
      {
         if (!map.ContainsKey(c))
         {
            map[c] = 0;
         }

         map[c]++;
      }

      int length = 0;
      bool hasOdd = false;

      foreach (var letter in map)
      {
         int count = letter.Value;

         length += (count / 2) * 2;

         if (count % 2 == 1)
         {
            hasOdd = true;
         }
      }

      if (hasOdd) length++;
      
      return length;
   }
}
