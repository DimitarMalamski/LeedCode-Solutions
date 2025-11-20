// Problem 3668. Restore Finishing Order
// Link https://leetcode.com/problems/restore-finishing-order/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] arags)
   {
      int[] order = { 3, 1, 2, 5, 4 };
      int[] friends = { 1, 3, 4 };
      int[] output = RecoverOrder(order, friends);
      Console.WriteLine(string.Join(", ", output));
   }

   static int[] RecoverOrder(int[] order, int[] friends)
   {
      HashSet<int> friendSet = new HashSet<int>(friends);
      List<int> result = new List<int>();

      foreach (int id in order)
      {
         if (friendSet.Contains(id))
         {
            result.Add(id);
         }
      }

      return result.ToArray();
   }
}
