// Problem 169. Majority Element
// Link https://leetcode.com/problems/majority-element/description/?envType=problem-list-v2&envId=hash-table
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 2, 2, 1, 1, 1, 2, 2 };
      int output = MajorityElement(nums);
      Console.WriteLine(output);
   }
   public static int MajorityElement(int[] nums)
   {
      Dictionary<int, int> numbers = new Dictionary<int, int>();

      foreach (int num in nums) {
         if (numbers.ContainsKey(num)) {
               numbers[num]++;
         }
         else {
               numbers[num] = 1;
         }
      }

      foreach(var key in numbers) {
         if (key.Value > nums.Length / 2) return key.Key;
      }

      return 0;
   }
}
