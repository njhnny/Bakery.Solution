using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    
    [TestMethod]
    public void Pastry_Instantiates_Pastry()
    {
      //Arrange
      Pastry testOrder = new Pastry(1);
      //Act??
      //Assert
      Assert.AreEqual(typeof(Pastry), testOrder.GetType());
    }
  }
}