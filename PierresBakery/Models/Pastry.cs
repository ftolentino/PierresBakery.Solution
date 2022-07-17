using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    // properties
    private static double _Price = 2;
    private double _DealOne;
    public int Quantity { get; set; }

    // Price property
    public static double Price
    {
      get { return _Price; }
      set { _Price = value; }
    }

    // Pastry constructor
    public Pastry(int quantity)
    {
      _Price = Price;
      _DealOne = 1;
      Quantity = quantity;
    }

    public double PastryCost()
    {
      double pastryTotal = 0;
      for (int index = 0; index <= Quantity; index++)
      {
        if (index == 0)
        {
          pastryTotal += 0;
        }
        // every 3rd pastry is $1 off
        else if (index % 3 == 0)
        {
          pastryTotal += _Price - _DealOne;
        }
        else
        {
          pastryTotal += _Price;
        }
      }
      return pastryTotal;
    }
  }
}
