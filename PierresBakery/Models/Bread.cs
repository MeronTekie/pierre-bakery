using System;
using System.Collections.Generic;
using Pastries.Models;
using Breads.Models;
using PierresBakeries.Models;




namespace Breads.Models

{
  public class Bread
  {

    public double totalBreadPrice( double numOfBread)
    {
      double breadPrice =0;
      double modulo =0;
      if( numOfBread % 3 ==0)
      {
        breadPrice = (numOfBread/3)*10;
      }
      else
      {
        modulo=numOfBread%3;
        breadPrice = (Math.Floor(numOfBread/3)*10) + (modulo*5);
      }
      return breadPrice;
    }
  }
}