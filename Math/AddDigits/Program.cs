// Problem 258. Add Digits
// Link https://leetcode.com/problems/add-digits/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int num = 38;
      int output = AddDigitsSolutionTwo(num);
      Console.WriteLine(output);
   }
   static int AddDigits(int num)
   {
      if (num < 10)
      {
         return num;
      }

      int sum = 0;

      while (num > 0)
      {
         int digit = num % 10;
         num /= 10;
         sum += digit;
      }

      return AddDigits(sum);
   }
   static int AddDigitsSolutionTwo(int num)
   {
      if (num == 0) return 0;
      int rem = num % 9;
      return rem == 0 ? 9 : rem;
   }
}
