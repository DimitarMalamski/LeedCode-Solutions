// Problem 1. Valid Anagram
// Link https://leetcode.com/problems/valid-anagram/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string s = "jer", t = "jam";
      bool answer = SolutionTwo(s, t);
      Console.WriteLine(answer);
   }
   static bool SolutionOne(string s, string t)
   {
      Dictionary<char, int> sSet = new Dictionary<char, int>();
      Dictionary<char, int> tSet = new Dictionary<char, int>();

      for (int i = 0; i < s.Length; i++)
      {
         if (!sSet.ContainsKey(s[i]))
         {
            sSet.Add(s[i], 1);
         }
         else
         {
            sSet[s[i]]++;
         }
      }

      for (int i = 0; i < t.Length; i++)
      {
         if (!tSet.ContainsKey(t[i]))
         {
            tSet.Add(t[i], 1);
         }
         else
         {
            tSet[t[i]]++;
         }
      }

      return sSet.OrderBy(kv => kv.Key).SequenceEqual(tSet.OrderBy(kv => kv.Key));
   }

   static bool SolutionTwo(string s, string t)
   {
      if (s.Length != t.Length) return false;

      int[] count = new int[26];

      for (int i = 0; i < s.Length; i++)
      {
         count[s[i] - 'a']++;
         count[t[i] - 'a']--;
      }

      foreach (int val in count)
      {
         if (val != 0)
         {
            return false;
         }
      }

      return true;
   }
}
