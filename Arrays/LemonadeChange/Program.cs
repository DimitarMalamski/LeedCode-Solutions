// Problem 860. Lemonade Change
// Link https://leetcode.com/problems/lemonade-change/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] bills = { 5,5,10,10,20 };
      bool output = LemonadeChange(bills);
      Console.WriteLine(output);
   }
   static bool LemonadeChange(int[] bills)
   {
      int five = 0, ten = 0;

      foreach (int bill in bills)
      {
         if (bill == 5)
         {
            five++;
         }
         else if (bill == 10)
         {
            if (five == 0) return false;
            five--;
            ten++;
         }
         else
         {
            if (ten > 0 && five > 0)
            {
               ten--;
               five--;
            }
            else if (five >= 3)
            {
               five -= 3;
            }
            else
            {
               return false;
            }
         }
      }

      return true;
   }
}
