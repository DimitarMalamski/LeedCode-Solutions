// Problem 1232. Check If It Is a Straight Line
// Link https://leetcode.com/problems/check-if-it-is-a-straight-line/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[][] coordinates = {
         new int[] {1, 2},
         new int[] {2, 3},
         new int[] {3, 4},
         new int[] {4, 5},
         new int[] {5, 6},
         new int[] {6, 7}
      };

      bool output = CheckStraightLine(coordinates);
      Console.WriteLine(output);
   }
   static bool CheckStraightLine(int[][] coordinates)
   {
      // Calculate the base differences from the first two points
        int x0 = coordinates[0][0], y0 = coordinates[0][1];
        int x1 = coordinates[1][0], y1 = coordinates[1][1];

        int dx = x1 - x0;
        int dy = y1 - y0;

        // Compare slope (cross product form) for every other point
        for (int i = 2; i < coordinates.Length; i++)
        {
            int x = coordinates[i][0];
            int y = coordinates[i][1];

            // Check if slope (dy/dx) == slope of first line
            if (dy * (x - x0) != dx * (y - y0))
                return false;
        }

        return true;
   }
   
}