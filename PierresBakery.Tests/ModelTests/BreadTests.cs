using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace BreadTests.Tests
{
  [TestClass]
  public class BreadTests // : IDisposable
  {
    // public void Dispose()
    // {
    //   ClassName.ClearAll();
    // }

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetNumber_ReturnNumber_Number()
    {
      int number = 1;
      Bread newBread = new Bread(number);
      int result = newBread.Number;
      Assert.AreEqual(number, result);
    }
  }
}