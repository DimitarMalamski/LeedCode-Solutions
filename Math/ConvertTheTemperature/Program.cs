// Problem 2469. Convert the Temperature
// Link https://leetcode.com/problems/convert-the-temperature/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      double celsius = 36.50;
      double[] output = ConvertTemperature(celsius);
      Console.WriteLine(string.Join(", ", output));
   }
   static double[] ConvertTemperature(double celsius)
   {
      double[] result = new double[2];
      result[0] = celsius + 273.15;
      result[1] = celsius * 1.80 + 32.00;
      return result; 
   }
}
