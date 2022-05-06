using System;
using System.Collections.Generic;
using Pastries.Models;
using Breads.Models;
using PierresBakeries.Models;


public class Program
{
  public static void Main()
  {
    try
    {

    Bread totalBreadPrice =new Bread();
    Pastry totalPastryPrice =new Pastry();  
    Bakery totalBakeryPrice =new Bakery();
    
    Console.WriteLine("How many cakes would like for today?");
    double numberOfCakes = double.Parse(Console.ReadLine());
    
    Console.WriteLine("How many bread would like for today?");
    double numberOfBread = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Your total for today will be:"+totalBakeryPrice.totalPriceForBreadAndPastry(numberOfCakes,numberOfBread)+" USD");
    
    }
    catch(Exception exception)
    {
      Console.WriteLine(exception.Message +":Enter a valid number");
    }
  }
}