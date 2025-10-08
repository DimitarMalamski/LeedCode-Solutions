// Problem 1502. Can Make Arithmetic Progression From Sequence
// Link https://leetcode.com/problems/can-make-arithmetic-progression-from-sequence/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] arr = { 1,2,4 };
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
}
