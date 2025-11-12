// Problem 219. Contains Duplicate II
// Link https://leetcode.com/problems/contains-duplicate-ii/description/?envType=problem-list-v2&envId=hash-table
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 1, 2, 3, 1 };
      int k = 3;
      bool output = ContainsNearbyDuplicate(nums, k);
      Console.WriteLine(output);
   }
   public static bool ContainsNearbyDuplicate(int[] nums, int k)
   {
      HashSet<int> window = new HashSet<int>();

      for (int i = 0; i < nums.Length; i++)
      {
         if (window.Contains(nums[i])) return true;

         window.Add(nums[i]);

         if (window.Count > k)
         {
            window.Remove(nums[i - k]);
         }
      }

      return false;
   }
}
