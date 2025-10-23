// Problem 2894. Divisible and Non-divisible Sums Difference
// Link https://leetcode.com/problems/divisible-and-non-divisible-sums-difference/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int n = 5, m = 1;
      int output = DifferenceOfSums(n, m);
      Console.WriteLine(output);
   }
   static int DifferenceOfSums(int n, int m)
   {
      int num1 = 0;
      int num2 = 0;

      for (int i = 1; i <= n; i++)
      {
         if (i % m == 0)
         {
            num2 += i;
         }
         else
         {
            num1 += i;
         }
      }

      return num1 - num2;
   }
}
