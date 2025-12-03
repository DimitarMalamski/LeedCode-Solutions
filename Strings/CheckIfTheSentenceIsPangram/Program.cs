// Problem 1832. Check if the Sentence Is Pangram
// Link https://leetcode.com/problems/check-if-the-sentence-is-pangram/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string sentence = "thequickbrownfoxjumpsoverthelazydog";
      bool output = CheckIfPangramOptimized(sentence);
      Console.WriteLine(output);
   }
   static bool CheckIfPangram(string sentence)
   {
      string filtered = sentence.ToLower();

      for (int i = 0; i < 26; i++)
      {
         char letter = (char)('a' + i);

         if (!filtered.Contains(letter)) return false;
      }

      return true;
   }

   static bool CheckIfPangramOptimized(string sentence)
   {
      HashSet<char> letters = new HashSet<char>(sentence);
      return letters.Count == 26;
   }
}
