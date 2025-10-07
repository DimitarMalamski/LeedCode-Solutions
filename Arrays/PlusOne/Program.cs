// Problem 66. Plus One
// Link https://leetcode.com/problems/plus-one/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] digits = { 1, 2, 3 };
      int[] output = PlusOne(digits);
      Console.WriteLine(string.Join(",", output));
   }
   static int[] PlusOne(int[] digits)
   {
      for (int i = digits.Length - 1; i >= 0; i--)
      {
         if (digits[i] != 9)
         {
            digits[i]++;
            return digits;
         }
         else
         {
            digits[i] = 0;
         }
      }

      int[] result = new int[digits.Length + 1];
      result[0] = 1;

      return result;
   }
}