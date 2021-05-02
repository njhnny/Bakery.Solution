namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCost = 5;
    public int BreadNumber { get; }
    public Bread(int breadNumber)
    {
      BreadNumber = breadNumber;
    }

    public int BreadCalculate()
    {
      int breadDiscount = BreadCost * ((BreadNumber - BreadNumber % 3) / 3);
      int BreadTotal = BreadNumber * BreadCost - breadDiscount;
      //requested number of loaves must include free loaves
      return BreadTotal;
    }
  }
}