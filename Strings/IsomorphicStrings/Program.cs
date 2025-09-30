// Problem 205. Isomorphic Strings
// Link https://leetcode.com/problems/isomorphic-strings/description/?envType=problem-list-v2&envId=hash-table
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      string s = "bbbaaaba";
      string t = "aaabbbba";
      bool output = IsIsomorphic(s, t);
      Console.WriteLine(output);
   }
   static bool IsIsomorphic(string s, string t)
   {
      if (s.Length != t.Length) return false;

      Dictionary<int, int> mapST = new Dictionary<int, int>();
      Dictionary<int, int> mapTS = new Dictionary<int, int>();

      for (int i = 0; i < s.Length; i++)
      {
         char c1 = s[i];
         char c2 = t[i];

         if (mapST.ContainsKey(c1))
         {
            if (mapST[c1] != c2) return false;
         }
         else
         {
            mapST[c1] = c2;
         }

         if (mapTS.ContainsKey(c2))
         {
            if (mapTS[c2] != c1) return false;
         }
         else
         {
            mapTS[c2] = c1;
         }
      }

      return true;
   }
}
