// Problem 605. Can Place Flowers
// Link https://leetcode.com/problems/can-place-flowers/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Easy

class Solution
{
   static void Main(string[] args)
   {
      int[] flowerbed = { 1, 0, 1, 0, 1 };
      int n = 1;

      bool output = CanPlaceFlowersSolutionTwo(flowerbed, n);
      Console.WriteLine(output);
   }

   static bool CanPlaceFlowers(int[] flowerbed, int n)
   {
      for (int i = 0; i < flowerbed.Length && n > 0; i++)
      {
         if (flowerbed[i] == 0)
         {
            bool left = (i == 0) || (flowerbed[i - 1] == 0);
            bool right = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);

            if (left && right)
            {
               flowerbed[i] = 1;
               n--;
            }
         }
      }

      return n <= 0;
   }

   static bool CanPlaceFlowersSolutionTwo(int[] flowerbed, int n)
   {
      for (int i = 0; i < flowerbed.Length && n > 0; i++)
      {
         if (flowerbed[i] == 0)
         {
            bool left = (i == 0) || (flowerbed[i - 1] == 0);
            bool right = (i == flowerbed.Length - 1) || (flowerbed[i + 1] == 0);

            if (left && right)
            {
               n--;
               i++;
               // we do not modify the array here, but skip the next pot
            }
         }
      }

      return n <= 0;
   }
}
