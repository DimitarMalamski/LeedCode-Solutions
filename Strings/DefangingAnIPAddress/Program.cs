// Problem 1108. Defanging an IP Address
// Link https://leetcode.com/problems/defanging-an-ip-address/description/
// Difficulty: Easy
class Solution
{
   static void Main(string[] args)
   {
      string address = "1.1.1.1";
      string output = DefangIPaddr(address);
      Console.WriteLine(output);
   }
   static string DefangIPaddr(string address)
      => address.Replace(".", "[.]");
}