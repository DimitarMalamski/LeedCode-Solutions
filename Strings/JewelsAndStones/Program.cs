// Problem 771. Jewels and Stones
// Link https://leetcode.com/problems/jewels-and-stones/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string jewels = "aA";
      string stones = "aAAbbbb";
      int output = NumJewelsInStones(jewels, stones);
      Console.WriteLine(output);
   }
   static int NumJewelsInStones(string jewels, string stones)
   {
      int count = 0;

      char[] chars = jewels.ToCharArray();
      char[] stoneChars = stones.ToCharArray();

      foreach (var stone in stoneChars)
      {
         if (chars.Contains(stone))
         {
            count++;
         }
      }

      return count;
   }
}
