// Problem 657. Robot Return to Origin
// Link https://leetcode.com/problems/robot-return-to-origin/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string moves = "LL";
      bool output = JudgeCircle(moves);
      Console.WriteLine(output);
   }
   static bool JudgeCircle(string moves)
   {
      int x = 0;
      int y = 0;

      foreach (char move in moves)
      {
         switch (move)
         {
            case 'U':
               y++;
               break;
            case 'D':
               y--;
               break;
            case 'L':
               x--;
               break;
            case 'R':
               x++;
               break;
         }
      }

      return x == 0 && y == 0;
   }
}

