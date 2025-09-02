// Problem 412. Fizz Buzz
// Link https://leetcode.com/problems/fizz-buzz/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int input = 15;
      string[] output = SolutionOne(input);
      Console.WriteLine(string.Join(",", output));
   }
   static string[] SolutionOne(int input)
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

   static string[] SolutionTwo(int input)
   {
      string[] output = new string[input];

      for (int i = 0; i < input; i++)
      {
         string current = "";

         if ((i + 1) % 3 == 0)
         {
            current += "Fizz";
         }

         if ((i + 1) % 5 == 0)
         {
            current += "Buzz";
         }

         if (current == "")
         {
            current = (i + 1).ToString();
         }

         output[i] = current;
      }

      return output;
   }
}
