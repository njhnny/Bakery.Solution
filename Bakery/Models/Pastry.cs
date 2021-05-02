namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCost = 2;
    public int ThreePastriesCost = 5;
    public int PastryNumber { get; set; }
    public Pastry(int pastryNumber)
    {
      PastryNumber = pastryNumber;
    }
    public int PastryCalculate()
    {
      int pastryRemainder = PastryNumber % 3;
      int pastryTrios = (PastryNumber - pastryRemainder) / 3;
    
    int PastryTotal = (pastryTrios * ThreePastriesCost) + (pastryRemainder * PastryCost);

    return PastryTotal;
    }
  }
}