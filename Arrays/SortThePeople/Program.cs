// Problem 2418. Sort the People
// Link https://leetcode.com/problems/sort-the-people/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string[] names = { "Mary", "John", "Emma" };
      int[] heights = { 180, 165, 170 };
      string[] output = SortPeople(names, heights);
      Console.WriteLine(string.Join(", ", output));
   }
   static string[] SortPeople(string[] names, int[] heights)
   {
      int n = names.Length;

      var people = new (string name, int height)[n];

      for (int i = 0; i < n; i++)
      {
         people[i] = (names[i], heights[i]);
      }

      Array.Sort(people, (a, b) => b.height.CompareTo(a.height));

      string[] result = new string[n];

      for (int i = 0; i < n; i++)
      {
         result[i] = people[i].name;
      }

      return result;
   }
}
