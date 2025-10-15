// Problem 1275. Find Winner on a Tic Tac Toe Game
// Link https://leetcode.com/problems/find-winner-on-a-tic-tac-toe-game/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[][] moves = new int[][]
      {
         new int[] { 0, 0 },
         new int[] { 2, 0 },
         new int[] { 1, 1 },
         new int[] { 2, 1 },
         new int[] { 2, 2 }
      };

      string output = Tictactoe(moves);
      Console.WriteLine(output);
   }
   static string Tictactoe(int[][] moves)
   {
      int[] rows = new int[3];
        int[] cols = new int[3];
        int diag = 0;
        int antiDiag = 0;

        for (int i = 0; i < moves.Length; i++)
        {
            int r = moves[i][0];
            int c = moves[i][1];

            int player = (i % 2 == 0) ? 1 : -1;

            rows[r] += player;
            cols[c] += player;

            if (r == c)
                diag += player;

            if (r + c == 2)
                antiDiag += player;

            if (Math.Abs(rows[r]) == 3 ||
                Math.Abs(cols[c]) == 3 ||
                Math.Abs(diag) == 3 ||
                Math.Abs(antiDiag) == 3)
            {
                return player == 1 ? "A" : "B";
            }
        }
        
        return moves.Length == 9 ? "Draw" : "Pending";
   }
}
