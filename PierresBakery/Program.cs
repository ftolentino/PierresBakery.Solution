using System;
using System.Collections.Generic;
using System.Linq;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  public class Program
  {
  public static void Main() 
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("A loaf of bread costs $5 and a pastry is $2.");
    Console.WriteLine("Bread Deals: For every 2 loaves of bread, you get the 3rd free!");
    Console.WriteLine("Pastry Deals: For every 3 pastries, you get $1 off!");

    Console.WriteLine("Enter how many loaves of bread you would like to purchase");
    int breadOrder = int.Parse(Console.ReadLine());
    Bread userBread = new Bread(breadOrder);
    double userBreadTotal = userBread.BreadCost();
    Console.WriteLine("Your bread total is $" + userBreadTotal);

    Console.WriteLine("Enter how many pastries you would like to purchase");
    int pastryOrder = int.Parse(Console.ReadLine());
    Pastry userPastry = new Pastry(pastryOrder);
    double userPastryTotal = userPastry.PastryCost();
    Console.WriteLine("Your pastry total is $" + userPastryTotal);

    double usertotalOrder = userBreadTotal + userPastryTotal;
    Console.WriteLine("Your total order is $" + usertotalOrder);
  }
  }
}
// Bread Loaf deal
// single loaf = $5
// every 3rd loaf is free

// Pastry Discount
// 1 = $2
// every 3rd pastry is $1 off
