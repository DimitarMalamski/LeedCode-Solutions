// Problem 2520. Count the Digits That Divide a Number
// Link https://leetcode.com/problems/count-the-digits-that-divide-a-number/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int num = 121;
      int output = CountDigits(num);
      Console.WriteLine(output);
   }
   static int CountDigits(int num)
   {
      int count = 0;

      int original = num;

      while (num > 0)
      {
         int digit = num % 10;
         if (original % digit == 0) count++;
         num /= 10;
      }

      return count;
   }
}
