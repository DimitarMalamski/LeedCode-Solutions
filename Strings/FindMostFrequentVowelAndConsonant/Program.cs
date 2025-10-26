// Problem 3541. Find Most Frequent Vowel and Consonant
// Link https://leetcode.com/problems/find-most-frequent-vowel-and-consonant/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string s = "successes";
      int output = MaxFreqSum(s);
      Console.WriteLine(output);
   }
   static int MaxFreqSum(string s)
   {
      HashSet<char> vowels = new HashSet<char>() { 'a', 'e', 'i', 'o', 'u' };
      Dictionary<char, int> freq = new Dictionary<char, int>();

      foreach (char letter in s)
      {
         if (!freq.ContainsKey(letter))
         {
            freq[letter] = 0;
         }

         freq[letter]++;
      }

      int maxVowel = 0;
      int maxConsonant = 0;

      foreach (var pair in freq)
        {
            if (vowels.Contains(pair.Key))
                maxVowel = Math.Max(maxVowel, pair.Value);
            else
                maxConsonant = Math.Max(maxConsonant, pair.Value);
        }

        return maxVowel + maxConsonant;
   }
}
