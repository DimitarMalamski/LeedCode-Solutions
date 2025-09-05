// Problem 383. Ransom Note
// Link https://leetcode.com/problems/ransom-note/description/
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      string ransomNote = "aa", magazine = "ab";
      bool output = SolutionTwo(ransomNote, magazine);
      Console.WriteLine(output);
   }
   static bool SolutionOne(string ransomNote, string magazine)
   {
      Dictionary<char, int> hash = new Dictionary<char, int>();

      for (int i = 0; i < ransomNote.Length; i++)
      {
         char letter = ransomNote[i];

         if (!hash.ContainsKey(letter))
         {
            hash.Add(letter, 1);
         }
         else
         {
            hash[letter] += 1;
         }
      }

      for (int i = 0; i < magazine.Length; i++)
      {
         char letter = magazine[i];

         if (hash.ContainsKey(letter) && hash[letter] >= 1)
         {
            hash[letter] -= 1;
         }
         else
         {
            continue;
         }
      }

      foreach (var item in hash)
      {
         if (item.Value != 0)
         {
            return false;
         }
      }

      return true;
   }

   static bool SolutionTwo(string ransomNote, string magazine)
   {
      for (int i = 0; i < ransomNote.Length; i++)
      {
         char letter = ransomNote[i];

         int matchingIndex = magazine.IndexOf(letter);

         if (matchingIndex == -1) return false;

         magazine = magazine.Substring(0, matchingIndex) + magazine.Substring(matchingIndex + 1);
      }

      return true;
   }
}