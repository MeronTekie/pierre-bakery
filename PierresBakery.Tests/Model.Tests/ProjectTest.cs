
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Pastries.Models;
using Breads.Models;
// using Programs.Models;
using PierresBakeries.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PriceTests
  {
    [TestMethod]
    public void Bread_ResultsTotalPriceOfBread_TotalBreadPrice()
    {
      Bread total = new Bread();
      Assert.AreEqual(15,total.totalBreadPrice(4));
    }
    [TestMethod]
    public void Bread_PrommotionResultToGiveEveryThirdBreadForFree_TotalBreadPrice()
    {   
      Bread total = new Bread();
      Assert.AreEqual(30,total.totalBreadPrice(8));
    }
    [TestMethod]
    public void Pastry_ResultsTotalPriceOfPastryPrice_TotalPastryPrice()
    {
      Pastry pasrtyPrice = new Pastry();
      Assert.AreEqual(4,pasrtyPrice.totalPastryPrice(2));
    }
    [TestMethod]
    public void Pastry_PrommotionResultToGiveEveryThirdPastryForFiftypercentOff_TotalPastryPrice()
    {   
      Pastry pasrtyPrice = new Pastry();
      Assert.AreEqual(10,pasrtyPrice.totalPastryPrice(6));
    }
    [TestMethod]
    public void Bakery_TotalPriceForBreadAndPastry_TotalBakeryPrice()
    {   
      Bakery bakeryPrice = new Bakery();
      Assert.AreEqual(24,bakeryPrice.totalPriceForBreadAndPastry(2,6));
    }
  
  }
}




