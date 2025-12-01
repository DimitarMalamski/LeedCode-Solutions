// Problem 2652. Sum Multiples
// Link https://leetcode.com/problems/sum-multiples/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int n = 7;
      int output = SumOfMultiples(n);
      Console.WriteLine(output);
   }
   static int SumOfMultiples(int n)
   {
      int result = 0;

      for (int i = 1; i <= n; i++)
      {
         if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0) result += i;
      }

      return result;
   }
}
