// Problem 13. Roman to Integer
// Link https://leetcode.com/problems/roman-to-integer/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string s = "MCMXCIV";
      int output = RomanToIntOptimized(s);
      Console.WriteLine(output);
   }
   static int RomanToInt(string s)
   {
      // III
      Dictionary<char, int> romanMap = new Dictionary<char, int>()
      {
         {'I', 1},
         {'V', 5},
         {'X', 10},
         {'L', 50},
         {'C', 100},
         {'D', 500},
         {'M', 1000}
      };

      int total = 0;

      for (int i = 0; i < s.Length; i++)
      {
         int current = romanMap[s[i]];

         if (i + 1 < s.Length && current < romanMap[s[i + 1]])
         {
            total -= current;
         }
         else
         {
            total += current;
         }
      }

      return total;

   }
   static int RomanToIntOptimized(string s)
   {
      int total = 0;
      int i = 0;

      while (i < s.Length - 1)
      {
         int current = GetValue(s[i]);
         int next = GetValue(s[i + 1]);

         if (current < next)
         {
            total -= current;
         }
         else
         {
            total += current;
         }

         i++;
      }

      total += GetValue(s[^1]);

      return total;
   }

   static int GetValue(char c)
   {
      return c switch
      {
         'I' => 1,
         'V' => 5,
         'X' => 10,
         'L' => 50,
         'C' => 100,
         'D' => 500,
         'M' => 1000,
         _ => 0
      };
   }
}
