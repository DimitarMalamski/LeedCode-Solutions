// Problem 2215. Find the Difference of Two Arrays
// Link https://leetcode.com/problems/find-the-difference-of-two-arrays/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      int[] nums1 = { 1, 2, 3 };
      int[] nums2 = { 2, 4, 6 };
      List<List<int>> output = FindDiffereceOptimized(nums1, nums2);

      string result = "[" + string.Join(",", output.Select(inner => "[" + string.Join(",", inner) + "]")) + "]";
      Console.WriteLine(result);
   }
   static List<List<int>> FindDifferece(int[] nums1, int[] nums2)
   {
      HashSet<int> set1 = new HashSet<int>(nums1);
      HashSet<int> set2 = new HashSet<int>(nums2);

      List<int> list1 = new List<int>();
      List<int> list2 = new List<int>();

      foreach (int item in set1)
      {
         if (!set2.Contains(item))
         {
            list1.Add(item);
         }
      }

      foreach (int item in set2)
      {
         if (!set1.Contains(item))
         {
            list2.Add(item);
         }
      }

      return new List<List<int>>() { list1, list2 };
   }

   static List<List<int>> FindDiffereceOptimized(int[] nums1, int[] nums2)
   {
      HashSet<int> set1 = new HashSet<int>(nums1);
      HashSet<int> set2 = new HashSet<int>(nums2);

      return new List<List<int>>
      {
         set1.Except(set2).ToList(),
         set2.Except(set1).ToList()
      };
   }
}
