// Problem 136. Single Number
// Link https://leetcode.com/problems/single-number/description/?envType=problem-list-v2&envId=array
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] input = { 4, 1, 2, 1, 2 };
      int output = SingleNumberXOR(input);
      Console.WriteLine(output);
   }
   static int SingleNumber(int[] input)
   {
      Dictionary<int, int> map = new Dictionary<int, int>();

      foreach (int num in input)
      {
         if (!map.ContainsKey(num))
         {
            map[num] = 0;
         }

         map[num]++;
      }

      return map.FirstOrDefault(x => x.Value == 1).Key;
   }

   static int SingleNumberXOR(int[] input)
   {
      int result = 0;

      foreach (int num in input)
      {
         result ^= num;
      }

      return result;
   }
}
