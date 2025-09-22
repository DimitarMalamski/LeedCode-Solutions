// Problem 283. Move Zeroes
// Link https://leetcode.com/problems/move-zeroes/description/?envType=study-plan-v2&envId=leetcode-75
// Difficulty: Easy

class Solution {
    static void Main(string[] args) {
        int[] input = { 2,1 };
        MoveZeroes(input);
        Console.WriteLine(string.Join(',', input));
    }

    static void MoveZeroes(int[] nums)
    {
        int pos = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[pos] = nums[i];
                pos++;
            }
        }

        while (pos < nums.Length)
        {
            nums[pos] = 0;
            pos++;
        }
    }
}
