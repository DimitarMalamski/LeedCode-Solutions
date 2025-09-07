// Problem 20. Valid Parentheses
// Link https://leetcode.com/problems/valid-parentheses/description/
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      string input = "([])";
      bool output = SolutionOne(input);
      Console.WriteLine(output);
   }
   static bool SolutionOne(string input)
   {
      if (input.Length < 2)
      {
         return false;
      }

      Stack<char> stack = new Stack<char>();

      foreach (char item in input)
      {
         switch (item)
         {
            case '(':
            case '{':
            case '[':
               stack.Push(item);
               break;
            case ')':
               if (stack.Count == 0 || stack.Pop() != '(') return false;
               break;
            case '}':
               if (stack.Count == 0 || stack.Pop() != '{') return false;
               break;
            case ']':
               if (stack.Count == 0 || stack.Pop() != '[') return false;
               break;
         }
      }

      return stack.Count == 0;
   }
}
