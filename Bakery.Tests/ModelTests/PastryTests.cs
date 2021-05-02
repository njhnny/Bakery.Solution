using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    
    [TestMethod]
    public void PastryConstructor_Instantiates_Pastry()
    {
      Pastry testOrder = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), testOrder.GetType());
    }

    [TestMethod]
    public void PastryCalculate_ReturnsCostOfOnePastry_Int()
    {
      int singlePastryPrice = 2;
      Pastry testOrder = new Pastry(1);
      Assert.AreEqual(singlePastryPrice, testOrder.PastryCalculate());
    }

    [TestMethod]
    public void PastryCalculate_ReturnsCostOfThreePastries_Int()
    {
      int threePastryPrice = 5;
      Pastry testOrder = new Pastry(3);
      Assert.AreEqual(threePastryPrice, testOrder.PastryCalculate());
    }

    [TestMethod]
    public void PastryCalculate_ReturnsCostOfFourPastries_Int()
    {
      int fourPastryPrice = 7;
      Pastry testOrder = new Pastry(4);
      Assert.AreEqual(fourPastryPrice, testOrder.PastryCalculate());
    }
  }
}