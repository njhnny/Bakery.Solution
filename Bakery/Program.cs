using System;
using Bakery.Models;
namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Nick's bakery!");
      Console.WriteLine("Bread costs $2, Pastries cost $1");
      Console.WriteLine("How many loaves of bread would you like?");
      int breadNumber = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int pastryNumber = int.Parse(Console.ReadLine());
      int customerTotal = breadNumber + pastryNumber;
      Console.WriteLine("Your total is: $" + customerTotal);
    }
  }
}