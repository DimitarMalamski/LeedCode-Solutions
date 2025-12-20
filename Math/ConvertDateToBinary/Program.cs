// Problem 3280. Convert Date to Binary
// Link https://leetcode.com/problems/convert-date-to-binary/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string date = "2080-02-29";
      string output = ConvertDateToBinary(date);
      Console.WriteLine(output);
   }
   static string ConvertDateToBinary(string date)
   {
      string[] parts = date.Split('-');

      int year = int.Parse(parts[0]);
      int month = int.Parse(parts[1]);
      int day = int.Parse(parts[2]);

      string binaryYear = Convert.ToString(year, 2);
      string binaryMonth = Convert.ToString(month, 2);
      string binaryDay = Convert.ToString(day, 2);

      return $"{binaryYear}-{binaryMonth}-{binaryDay}";
   }
}
