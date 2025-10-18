// Problem 1491. Average Salary Excluding the Minimum and Maximum Salary
// Link https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] salary = { 4000, 3000, 1000, 2000 };
      double output = Average(salary);
      Console.WriteLine(output);
   }
   static double Average(int[] salary)
   {
      int min = Int32.MaxValue;
      int max = Int32.MinValue;
      int sum = 0;

      foreach (int item in salary)
      {
         if (item < min)
         {
            min = item;
         }

         if (item > max)
         {
            max = item;
         }

         sum += item;
      }

      return (double)(sum - min - max) / (salary.Length - 2);
   }
}
