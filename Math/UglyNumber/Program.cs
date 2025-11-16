// Problem 263. Ugly Number
// Link https://leetcode.com/problems/ugly-number/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int n = 6;
      bool output = IsUgly(n);
      Console.WriteLine(output);
   }
   static bool IsUgly(int n)
   {
      if (n <= 0) return false;

      int[] primes = { 2, 3, 5 };

      foreach (int p in primes)
      {
         while (n % p == 0)
         {
            n /= p;
         }
      }

      return n == 1;
   }
}
