using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PastryTests.Tests
{
  [TestClass]
  public class PastryTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   ClassName.ClearAll();
    // }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetQuantity_ReturnQauntity_Quantity()
    {
      int quantity = 1;
      Pastry newPastry = new Pastry(quantity);
      int result = newPastry.Quantity;
      Assert.AreEqual(quantity, result);
    }

    [TestMethod]
    public void SetQuantity_SetQuantity_Quantity()
    {
      int quantity = 1;
      Pastry newPastry = new Pastry(quantity);
      int updatedQuantity = 2;
      newPastry.Quantity = updatedQuantity;
      int result = newPastry.Quantity;
      Assert.AreEqual(updatedQuantity, result);
    }

    [TestMethod]
    public void PastryCost_ReturnPastryTotalNoDeal_Int()
    {
      // Arrange
      int quantity = 1;
      double pastryCost = 2;
      // Act
      Pastry newPastry = new Pastry(quantity);
      // Assert
      Assert.AreEqual(pastryCost, newPastry.PastryCost());
    }

    [TestMethod]
    public void PastryCost_ReturnPastryTotalDealOne_Int()
    {
      // Arrange
      int quantity = 6;
      double pastryTotal = 10;
      // Act
      Pastry newPastry = new Pastry(quantity);
      // Assert
      Assert.AreEqual(pastryTotal, newPastry.PastryCost());
    }
  }
}