using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace BreadTests.Tests
{
  [TestClass]
  public class BreadTests 
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnQauntity_Quantity()
    {
      int quantity = 1;
      Bread newBread = new Bread(quantity);
      int result = newBread.Quantity;
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void SetQuantity_SetQuantity_Quantity()
    {
      int quantity = 1;
      Bread newBread = new Bread(quantity);
      int updatedQuantity = 2;
      newBread.Quantity = updatedQuantity;
      int result = newBread.Quantity;
      Assert.AreEqual(updatedQuantity, result);
    }

    [TestMethod]
    public void BreadCost_ReturnBreadCostNoDeal_Int()
    {
      // Arrange
      int quantity = 1;
      double breadCost = 5;
      // Act
      Bread newBread = new Bread(quantity);
      // Assert
      Assert.AreEqual(breadCost, newBread.BreadCost());
    }

    [TestMethod]
    public void BreadTotal_ReturnBreadTotalDeal_Int()
    {
      // Arrange
      int quantity = 3;
      double breadTotal = 10;
      // Act
      Bread newBread = new Bread(quantity);
      // Assert
      Assert.AreEqual(breadTotal, newBread.BreadCost());
    }
  }
}