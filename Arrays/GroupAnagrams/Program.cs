// Problem 49. Group Anagrams
// Link https://leetcode.com/problems/group-anagrams/description/
// Difficulty: Medium

class Solution
{
   static void Main(string[] args)
   {
      string[] input = { "eat", "tea", "tan", "ate", "nat", "bat" };
      List<List<string>> output = GroupAnagrams(input);
      Console.WriteLine("[" + string.Join(", ", output.Select(inner => "[" + string.Join(", ", inner.Select(s => $"\"{s}\"")) + "]")) + "]");
   }

   static List<List<string>> GroupAnagrams(string[] input)
   {
      Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

      foreach (string word in input)
      {
         char[] chars = word.ToCharArray();
         Array.Sort(chars);
         string key = new string(chars);

         // If the dictionary does not contain this key, add a new list and insert the key to that list
         if (!map.ContainsKey(key))
         {
            map[key] = new List<string>();
         }

         map[key].Add(word);
      }

      return map.Values.ToList();
   }
}
