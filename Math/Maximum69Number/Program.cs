// Problem 1323. Maximum 69 Number
// Link https://leetcode.com/problems/maximum-69-number/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int num = 9669;
      int output = Maximum69Number(num);
      Console.WriteLine(output);
   }
   static int Maximum69Number(int num)
   {
      char[] digits = num.ToString().ToCharArray();

      for (int i = 0; i < digits.Length; i++)
      {
         if (digits[i] == '6')
         {
            digits[i] = '9';
            break;
         }
      }

      return int.Parse(digits);
   }
}
