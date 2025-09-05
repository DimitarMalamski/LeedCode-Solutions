// Problem 383. Ransom Note
// Link https://leetcode.com/problems/ransom-note/description/
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      string ransomNote = "aa", magazine = "ab";
      bool output = SolutionOne(ransomNote, magazine);
      Console.WriteLine(output);
   }
   static bool SolutionOne(string ransomNote, string magazine)
   {
      Dictionary<char, int> hash = new Dictionary<char, int>();

      foreach (char letter in magazine)
      {
         if (!hash.ContainsKey(letter))
         {
            hash[letter] = 0;
         }

         hash[letter]++;
      }

      foreach (char letter in ransomNote)
      {
         if (!hash.ContainsKey(letter) || hash[letter] == 0)
         {
            return false;
         }

         hash[letter]--;
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