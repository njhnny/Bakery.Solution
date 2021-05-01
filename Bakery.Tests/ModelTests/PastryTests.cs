using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakery.Models;
using System;

namespace Pastry.Tests
{
  [TestClass]
  public class Pastry Tests : IDisposable
  {
    public void Dispose()
    {
      Pastry.clearAll;
    }
    [TestMethod]
    public void NameOfTestMethod()
    {
      //Arrange
      //Act
      //Assert
    }
  }
}