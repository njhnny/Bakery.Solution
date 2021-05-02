namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCost = 2;
    public int PastryNumber { get; set; }
    public Pastry(int pastryNumber)
    {
      PastryNumber = pastryNumber;
    }
    public int PastryCalculate()
    {
    int PastryTotal = PastryCost;

    return PastryTotal;
    }
  }
}