// Problem 3516. Find Closest Person
// Link https://leetcode.com/problems/find-closest-person/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int x = 2, y = 7, z = 4;
      int output = FindClosest(x, y, z);
      Console.WriteLine(output);
   }
   static int FindClosest(int x, int y, int z)
   {
      return Math.Abs(x - z) < Math.Abs(y - z)
         ? 1
         : (Math.Abs(x - z) == Math.Abs(y - z)
            ? 0
            : 2);
   }
}
