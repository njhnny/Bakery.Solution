namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCost = 2;
    public int BreadNumber { get; set; }
    public Bread(int breadNumber)
    {
      BreadNumber = breadNumber;
    }

    public int BreadCalculate()
    {
      //buy 2 get one free
      return BreadTotal;
    }
  }
}