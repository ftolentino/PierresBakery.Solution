using System;
using PierresBakery.Models;

namespace PierresBakery.Models
{
  public class Program
  {
  public static void Main() 
  {
    Console.WriteLine("Welcome to Pierre's Bakery!");
    Console.WriteLine("A loaf of bread costs $5 and a pastry is $2.");
    Console.WriteLine("For every 2 loaves of bread, you get the 3rd free!");
    Console.WriteLine("Pastry Deals: 3 pastries for $5, 4 pastries for $7, 5 pastries for $9, 6 pastries for $10");
    Console.WriteLine("Enter how many loaves of bread you would like to purchase");
  }
  }
}
// Bread Loaf deal
// every 3rd loaf is free

// Pastry Discount
// 1 = $2
// 3 = $5 $1 off
// 4 = 7 $1 off
// 5 = 9 $1 off
// 6 = 10 $2 off