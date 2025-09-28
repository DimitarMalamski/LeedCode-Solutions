// Problem 1207. Unique Number of Occurrences
// Link https://leetcode.com/problems/unique-number-of-occurrences/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] arr = { 1, 2, 2, 1, 1, 3 };
      bool output = UniqueOccurrences(arr);
      Console.WriteLine(output);
   }
   static bool UniqueOccurrences(int[] arr)
   {
      Dictionary<int, int> map = new Dictionary<int, int>();

      foreach (int number in arr)
      {
         if (!map.ContainsKey(number))
         {
            map.Add(number, 0);
         }

         map[number]++;
      }

      HashSet<int> set = new HashSet<int>();

      foreach (var item in map)
      {
         if (!set.Add(item.Value))
         {
            return false;
         }
      }

      return true;
   }
}
