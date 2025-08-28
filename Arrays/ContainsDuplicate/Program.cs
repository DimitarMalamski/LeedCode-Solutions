// Problem 217. Contains Duplicate
// Link https://leetcode.com/problems/contains-duplicate/description/
// Difficulty: Easy

class Program {
   static void Main(string[] args) {
      int[] nums = { 1, 2, 3, 3 };
      bool output = Solution(nums);
      Console.WriteLine(output);
   }
   static bool Solution(int[] nums)
   {
      HashSet<int> set = new HashSet<int>();

      foreach (int num in nums)
      {
         if (set.Contains(num))
         {
            return true;
         }
         set.Add(num);
      }

      return false;
   }
}
