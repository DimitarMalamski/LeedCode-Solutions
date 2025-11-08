// Problem 1295. Find Numbers with Even Number of Digits
// Link https://leetcode.com/problems/find-numbers-with-even-number-of-digits/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 12, 345, 2, 6, 7896 };
      int output = FindNumbers(nums);
      Console.WriteLine(output);
   }
   static int FindNumbers(int[] nums)
   {
      int count = 0;
      foreach (int num in nums)
      {
         if (FindDigits(num) % 2 == 0)
         {
            count++;
         }
      }

      return count;
   }

   private static int FindDigits(int number)
   {
      int count = 0;
      while (number != 0)
      {
         number /= 10;
         count++;
      }

      return count;
   }
}
