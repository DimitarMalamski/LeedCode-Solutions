// Problem 1071. Greatest Common Divisor of Strings
// Link https://leetcode.com/problems/greatest-common-divisor-of-strings/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      string str1 = "ABABAB";
      string str2 = "ABAB";

      string output = GcdOfStrings(str1, str2);
      Console.WriteLine(output);
   }
   static string GcdOfStrings(string str1, string str2)
   {
      if (str1 + str2 != str2 + str1)
      {
         return "";
      }

      int g = Gcd(str1.Length, str2.Length);

      return str1.Substring(0, g);
   }
   static int Gcd(int a, int b)
   {
      // Euclidean Algorithm
      while (b != 0)
      {
         int t = a % b;
         a = b;
         b = t;
      }

      return a;
   }
}
