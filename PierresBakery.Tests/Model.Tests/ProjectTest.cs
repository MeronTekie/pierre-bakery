
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Bakeries.Models;
using Pastries.Models;
using Programs.Models;
// using PierresBakeries.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PriceTests
  {
    [TestMethod]
    public void Pastry_ResultsTotalPrice_TotalPastryPrice()
    {
      
      Pastry total = new Pastry();
      Assert.AreEqual(6,total.totalPastryPrice(3));
      

    }

  }
}



