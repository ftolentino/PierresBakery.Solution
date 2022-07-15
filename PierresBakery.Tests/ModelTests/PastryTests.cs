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
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  }
}