// Problem 682. Baseball Game
// Link https://leetcode.com/problems/baseball-game/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      string[] operations = { "5", "-2", "4", "C", "D", "9", "+", "+" };
      int output = CalPointsOptimized(operations);
      Console.WriteLine(output);
   }
   static int CalPoints(string[] operations)
   {
      // "5", "2", "C", "D", "+"

      Stack<int> stack = new Stack<int>();

      for (int i = 0; i < operations.Length; i++)
      {
         if (int.TryParse(operations[i], out int n))
         {
            stack.Push(n);
         }
         else
         {
            switch (char.Parse(operations[i]))
            {
               case '+':
                  int numberOne = stack.Pop();
                  int numberTwo = stack.Pop();

                  int sumTwo = numberOne + numberTwo;

                  stack.Push(numberTwo);
                  stack.Push(numberOne);
                  stack.Push(sumTwo);
                  break;
               case 'D':
                  int current = stack.Pop();
                  int product = current * 2;
                  stack.Push(current);
                  stack.Push(product);
                  break;
               case 'C':
                  stack.Pop();
                  break;
            }
         }
      }

      int sum = 0;
      while (stack.Count > 0)
      {
         sum += stack.Pop();
      }

      return sum;
   }
   static int CalPointsOptimized(string[] operations)
   {
      Stack<int> stack = new Stack<int>();

      int sum = 0;

      foreach (var item in operations)
      {
         if (int.TryParse(item, out int n))
         {
            stack.Push(n);
            sum += n;
         }
         else
         {
            switch (item)
            {
               case "+":
                  int last = stack.Pop();
                  int secondLast = stack.Peek();
                  int sumTwo = last + secondLast;
                  stack.Push(last);
                  stack.Push(sumTwo);
                  sum += sumTwo;
                  break;
               case "D":
                  int doubleVal = stack.Peek() * 2;
                  stack.Push(doubleVal);
                  sum += doubleVal;
                  break;
               case "C":
                  int number = stack.Pop();
                  sum -= number;
                  break;
            }
         }
      }

      return sum;
   }
}
