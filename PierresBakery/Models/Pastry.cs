using System;
using System.Collections.Generic;
using Pastries.Models;
using Breads.Models;
using PierresBakeries.Models;



namespace Pastries.Models

{
  public class Pastry
  {
    public double totalPastryPrice( double numOfPastry)
  {
    double pastryPrice =0;
    double modulo =0;
    if( numOfPastry% 3 ==0)
    {
      pastryPrice = (numOfPastry/3)*5;
    }
    else
    {
      modulo=numOfPastry%3;
      pastryPrice = (Math.Floor(numOfPastry/3)*5) + (modulo*2);
    }
    return pastryPrice;
  }

  }
  
}