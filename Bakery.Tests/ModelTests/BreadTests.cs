using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_Instantiates_Bread()
    {
      Bread testOrder = new Bread(1);
      Assert.AreEqual(typeof(Bread), testOrder.GetType());
    }

    [TestMethod]
    public void BreadCalculate_ReturnsCostOfOneLoaf_Int()
    {
      int testBreadPrice = 5;
      Bread testOrder = new Bread(1);
      Assert.AreEqual(testBreadPrice, testOrder.BreadCalculate());
    }
  }
}