class Solution
{
   static void Main(string[] args)
   {
      int[,] accounts = new int[,] { { 2, 8, 7 },{ 7, 1, 3 },{ 1, 9, 5 } };
      int output = Check(accounts);
      Console.WriteLine(output);
   }

   static int Check(int[,] accounts)
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
}
