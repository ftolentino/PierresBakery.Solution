using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    // properties
    private static double _Price = 5;
    private double _Discount;
    public int Quantity { get; set; }

    // Price property
    public static double Price
    {
      get { return _Price; }
      set { _Price = value; }
    }
    // Bread constructor
    public Bread(int quantity)
    {
      _Price = Price;
      _Discount = 0;
      Quantity = quantity;
    }

    public double BreadCost()
    {
      double breadTotal = 0;
      for (int index = 0; index <= Quantity; index++)
      {
        if (index == 0)
        {
          breadTotal += 0;
        }
        else if(index % 3 == 0)
        {
          breadTotal += _Price * _Discount;
        }
        else
        {
          breadTotal += _Price;
        }
      }
      return breadTotal;
    }
  }
}