// Problem 2011. Final Value of Variable After Performing Operations
// Link https://leetcode.com/problems/final-value-of-variable-after-performing-operations/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string[] operations = { "--X", "X++", "X++" };
      int output = FinalValueAfterOperations(operations);
      Console.WriteLine(output);
   }
   static int FinalValueAfterOperations(string[] operations)
   {
      int value = 0;

      foreach (string operation in operations)
      {
         switch (operation)
         {
            case "--X":
               value--;
               break;
            case "++X":
               value++;
               break;
            case "X--":
               value--;
               break;
            case "X++":
               value++;
               break;
         }
      }

      return value;
   }
}
