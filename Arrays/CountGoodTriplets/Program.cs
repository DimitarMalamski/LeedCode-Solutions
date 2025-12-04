// Problem 1534. Count Good Triplets
// Link https://leetcode.com/problems/count-good-triplets/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] arr = { 3, 0, 1, 1, 9, 7 };
      int a = 7;
      int b = 2;
      int c = 3;
      int output = CountGoodTriplets(arr, a, b, c);
      Console.WriteLine(output);
   }
   static int CountGoodTriplets(int[] arr, int a, int b, int c)
   {
      int count = 0;
      int n = arr.Length;

      for (int i = 0; i < n; i++)
      {
         for (int j = 0; j < n; j++)
         {
            for (int k = 0; k < n; k++)
            {
               if (i < j && j < k)
               {
                  if (Math.Abs(arr[i] - arr[j]) <= a
                     && Math.Abs(arr[j] - arr[k]) <= b
                     && Math.Abs(arr[i] - arr[k]) <= c)
                  {
                     count++;
                  }
               }
            }
         }
      }

      return count;
   }
}
