// Problem 2942. Find Words Containing Character
// Link https://leetcode.com/problems/find-words-containing-character/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string[] words = { "leet", "code" };
      char x = 'e';
      List<int> output = FindWordsContaining(words, x);
      Console.WriteLine(string.Join(",", output));
   }
   static List<int> FindWordsContaining(string[] words, char x)
   {
      List<int> result = new List<int>();

      for (int i = 0; i < words.Length; i++)
      {

         char[] wordChar = words[i].ToCharArray();

         foreach (char letter in wordChar)
         {
            if (letter == x)
            {
               result.Add(i);
               break;
            }
         }
      }

      return result;
   }
}
