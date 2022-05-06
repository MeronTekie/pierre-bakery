using System;
using System.Collections.Generic;
using Pastries.Models;
using Breads.Models;
using PierresBakeries.Models;



namespace PierresBakeries.Models
{
  public class  Bakery
  {
    public double totalPriceForBreadAndPastry(double pastryPrice, double breadPrice)
    {
      Bread totalBPrice = new Bread();
      Pastry totalPPrice = new Pastry();  
      return totalPPrice.totalPastryPrice(pastryPrice)+totalBPrice.totalBreadPrice(breadPrice);
    }
  }
}
