// Problem 1. Two Sum
// Link https://leetcode.com/problems/two-sum/description/
// Difficulty: Easy

class Program {
   static void Main (string[] args) {
      int[] nums = { 3,3 };
      int target = 6;
      var result = TwoSumImproved(nums, target);
      Console.WriteLine($"[{result[0]}, {result[1]}]");
   }
   static int[] TwoSum(int[] nums, int target) {
      for (int i = 0; i < nums.Length; i++) {
         for (int j = i + 1; j < nums.Length; j++) {
            if (nums[i] + nums[j] == target) {
               return [i, j];
            }
         }
      }

      return null;
   }

   static int[] TwoSumImproved(int[] nums, int targer) {
      Dictionary<int,int> map = new Dictionary<int, int>();

      for (int i = 0; i < nums.Length; i++ ) {
         int leftover = targer - nums[i];

         if (map.ContainsKey(leftover)) {
            return new int[] { map[leftover], i };
         }
         
         if (!map.ContainsKey(nums[i])) {
            map.Add(nums[i], i);
         }
      }

      return null; 
   }
}
