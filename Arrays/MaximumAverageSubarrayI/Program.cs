﻿// Problem 643. Maximum Average Subarray I
// Link https://leetcode.com/problems/maximum-average-subarray-i/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      int[] nums = { 1, 12, -5, -6, 50, 3 };
      int k = 4;
      double output = FindMaxAverage(nums, k);
      Console.WriteLine(output);
   }
   static double FindMaxAverage(int[] nums, int k)
   {
      int sum = 0;
      for (int i = 0; i < k; i++)
      {
         sum += nums[i];
      }

      int maxSum = sum;

      for (int i = k; i < nums.Length; i++)
      {
         sum += nums[i] - nums[i - k];
         if (sum > maxSum) maxSum = sum;
      }

      return (double)maxSum / k;
   }
}