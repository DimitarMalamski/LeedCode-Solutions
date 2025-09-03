// Problem 1342. Number of Steps to Reduce a Number to Zero
// Link https://leetcode.com/problems/number-of-steps-to-reduce-a-number-to-zero/description/
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      int input = 123;
      int output = Check(input);
      Console.WriteLine(output);
   }
   static int Check(int input)
   {
      int count = 0;

      while (input != 0)
      {
         if (input % 2 == 0)
         {
            input /= 2;
            count++;
         }
         else
         {
            input -= 1;
            count++;
         }
      }

      return count;
   }
}
