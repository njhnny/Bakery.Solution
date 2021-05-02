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
    public void PastryCalculate_ReturnsCostOfPastries_Int()
    {
      int singlePastryPrice = 2;
      Pastry testOrder = new Pastry(1);
      Assert.AreEqual(singlePastryPrice, testOrder.PastryCalculate());
    }
  }
}