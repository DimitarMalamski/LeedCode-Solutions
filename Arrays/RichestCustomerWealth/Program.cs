// Problem 1672. Richest Customer Wealth
// Link https://leetcode.com/problems/richest-customer-wealth/description/
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      int[,] accounts = new int[,] { { 2, 8, 7 }, { 7, 1, 3 }, { 1, 9, 5 } };
      int output = SolutionTwo(accounts);
      Console.WriteLine(output);
   }

   static int SolutionOne(int[,] accounts)
   {
      int[] sums = new int[accounts.GetLength(0)];

      for (int row = 0; row < accounts.GetLength(0); row++)
      {
         int currentSum = 0;

         for (int col = 0; col < accounts.GetLength(1); col++)
         {
            currentSum += accounts[row, col];
         }

         sums[row] = currentSum;
      }

      int max = sums[0];

      for (int i = 1; i < sums.Length; i++)
      {
         if (sums[i] > max)
         {
            max = sums[i];
         }
      }

      return max;
   }

   static int SolutionTwo(int[,] accounts)
   {
      int maxWealth = 0;

      for (int row = 0; row < accounts.GetLength(0); row++)
      {
         int currentWealth = 0;

         for (int col = 0; col < accounts.GetLength(1); col++)
         {
            currentWealth += accounts[row, col];
         }

         if (currentWealth > maxWealth)
         {
            maxWealth = currentWealth;
         }
      }

      return maxWealth;
   }
}
