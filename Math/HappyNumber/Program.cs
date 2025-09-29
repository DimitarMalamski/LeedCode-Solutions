// Problem 202. Happy Number
// Link https://leetcode.com/problems/happy-number/description/?envType=problem-list-v2&envId=hash-table
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int n = 2;
      bool output = IsHappySolutionTwo(n);
      Console.WriteLine(output);
   }

   static int GetNext(int n)
   {
      int sum = 0;

      while (n > 0)
      {
         int digit = n % 10;
         n /= 10;
         sum += (digit * digit);
      }

      return sum;
   }
   static bool IsHappy(int n)
   {
      if (n == 1)
      {
         return true;
      }

      HashSet<int> set = new HashSet<int>();

      while (n != 1 && set.Add(n))
      {
         n = GetNext(n);
      }

      return n == 1;
   }
   static bool IsHappySolutionTwo(int n)
   {
      int slow = n;
      int fast = GetNext(n);

      while (fast != 1 && slow != fast)
      {
         slow = GetNext(slow);
         fast = GetNext(GetNext(fast));
      }

      return fast == 1;
   }
}