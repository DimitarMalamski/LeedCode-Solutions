// Problem 121. Best Time to Buy and Sell Stock
// Link https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] input = new int[] { 10, 1, 5, 6, 7, 1 };
      int output = SolutionOne(input);
      Console.WriteLine(output);
   }

   static int SolutionOne(int[] input)
   {
      int minPrice = int.MaxValue;
      int maxProfit = 0;

      foreach (int price in input)
      {
         if (price < minPrice)
         {
            minPrice = price;
         }

         int currentProfit = price - minPrice;
         if (currentProfit > maxProfit)
         {
            maxProfit = currentProfit;
         }
      }

      return maxProfit;
   }
}
