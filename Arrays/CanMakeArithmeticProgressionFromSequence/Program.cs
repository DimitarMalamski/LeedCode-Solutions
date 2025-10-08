// Problem 1502. Can Make Arithmetic Progression From Sequence
// Link https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] arr = { 1, 2, 4 };
      bool output = CanMakeArithmeticProgression(arr);
      Console.WriteLine(output);
   }
   static bool CanMakeArithmeticProgression(int[] arr)
   {
      Array.Sort(arr);
      int dif = Math.Abs(arr[0] - arr[1]);

      for (int i = 2; i < arr.Length; i++)
      {
         if (Math.Abs(arr[i - 1] - arr[i]) != dif) return false;
      }

      return true;
   }
   static bool CanMakeArithmeticProgressionOptimized(int[] arr)
   {
      int n = arr.Length;
      if (n <= 2) return true;

      int min = int.MaxValue, max = int.MinValue;
      foreach (int num in arr)
      {
         min = Math.Min(min, num);
         max = Math.Max(max, num);
      }

      if ((max - min) % (n - 1) != 0)
      {
         return false;
      }

      int diff = (max - min) / (n - 1);
      if (diff == 0)
      {
         foreach (int num in arr)
         {
            if (num != min) return false;
         }

         return true;
      }

      HashSet<int> seen = new HashSet<int>();
      foreach (int num in arr)
      {
         if ((num - min) % diff != 0) return false;
         if (!seen.Add(num)) return false;
      }

      return seen.Count == n;
   }
}
