// Problem 1572. Matrix Diagonal Sum
// Link https://leetcode.com/problems/matrix-diagonal-sum/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[][] matrix = new int[][]
      {
         new int[] { 1, 2, 3 },
         new int[] { 4, 5, 6 },
         new int[] { 7, 8, 9 },
      };

      int output = DiagonalSum(matrix);
      Console.WriteLine(output);
   }
   static int DiagonalSum(int[][] matrix)
   {
      int n = matrix.Length;
      int sum = 0;

      for (int i = 0; i < n; i++)
      {
         sum += matrix[i][i];
         sum += matrix[i][n - 1 - i];
      }

      if (n % 2 != 0)
      {
         sum -= matrix[n / 2][n / 2];
      }

      return sum;
   }
}
