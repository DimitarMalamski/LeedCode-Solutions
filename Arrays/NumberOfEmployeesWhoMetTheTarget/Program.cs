// Problem 2798. Number of Employees Who Met the Target
// Link https://leetcode.com/problems/number-of-employees-who-met-the-target/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] hours = { 0, 1, 2, 3, 4 };
      int target = 2;
      int output = NumberOfEmployeesWhoMetTarget(hours, target);
      Console.WriteLine(output);
   }

   static int NumberOfEmployeesWhoMetTarget(int hours, int target)
   {
      int count = 0;
      foreach (int hour in hours)
      {
         if (hour >= target)
         {
            count++;
         }
      }

      return count;
   }
}
