// Problem 412. Fizz Buzz
// Link https://leetcode.com/problems/fizz-buzz/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int input = 15;
      string[] output = Check(input);
      Console.WriteLine(string.Join(",", output));
   }
   static string[] Check(int input)
   {
      string[] output = new string[input];

      for (int i = 0; i < input; i++)
      {
         if (i == 0)
         {
            output[i] = "1";
            continue;
         }
         else if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
         {
            output[i] = "FizzBuzz";
         }
         else if ((i + 1) % 3 == 0)
         {
            output[i] = "Fizz";
         }
         else if ((i + 1) % 5 == 0)
         {
            output[i] = "Buzz";
         }
         else
         {
            output[i] = (i + 1).ToString();
         }
      }

      return output;
   }
}
