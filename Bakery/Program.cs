using System;
using Bakery.Models;
namespace Bakery
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Nick's bakery!");
      Console.WriteLine("Bread costs $5 per loaf. Buy two get one free!");
      Console.WriteLine("Pastries are $2 each or 3 for $5");
      Console.WriteLine("How many loaves of bread would you like?");
      Bread BreadNumber = new Bread (int.Parse(Console.ReadLine()));
      Console.WriteLine("How many pastries would you like?");
      Pastry PastryNumber = new Pastry (int.Parse(Console.ReadLine()));
      int customerTotal = BreadNumber.BreadCalculate() + PastryNumber.PastryCalculate();
      Console.WriteLine("Your total is: $" + customerTotal);
      
    }
  }
}