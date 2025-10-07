// Problem 1822. Sign of the Product of an Array
// Link https://leetcode.com/problems/sign-of-the-product-of-an-array/description/?envType=study-plan-v2&envId=programming-skills
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { -1, -2, -3, -4, 3, 2, 1 };
      int output = ArraySign(nums);
      Console.WriteLine(output);
   }
   static int ArraySign(int[] nums)
   {
      int product = 1;

      for (int i = 0; i < nums.Length; i++)
      {
         if (nums[i] < 0)
         {
            nums[i] = -1;
         }
         else if (nums[i] > 0)
         {
            nums[i] = 1;
         }
         else
         {
            return 0;
         }

         product *= nums[i];
      }

      if (product < 0)
      {
         return -1;
      }

      return 1;
   }
}
