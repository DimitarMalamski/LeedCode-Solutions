// Problem 202. Happy Number
// Link https://leetcode.com/problems/happy-number/description/?envType=problem-list-v2&envId=hash-table
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int n = 2;
      bool output = IsHappy(n);
      Console.WriteLine(output);
   }
   static bool IsHappy(int n)
   {
      if (n == 1)
      {
         return true;
      }

      HashSet<int> set = new HashSet<int>();

      while (n != 1)
      {
         int sum = 0;

         while (n > 0)
         {
            int digit = n % 10;
            n /= 10;
            sum += (digit * digit);
         }

         n = sum;

         if (!set.Add(sum))
         {
            return false;
         }
      }

      return true;
   }
}