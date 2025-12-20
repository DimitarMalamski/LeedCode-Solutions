// Problem 2413. Smallest Even Multiple
// Link https://leetcode.com/problems/smallest-even-multiple/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int n = 5;
      int output = SmallestEvenMultiple(n);
      Console.WriteLine(output);
   }
   static int SmallestEvenMultiple(int n)
      => n % 2 == 0 ? n : n * 2;
}
