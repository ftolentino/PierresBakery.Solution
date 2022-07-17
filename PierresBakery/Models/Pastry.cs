using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    // properties
    private static double _Price = 2;
    private double _DealOne;
    private double _DealTwo;
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
      _DealTwo = 2;
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
        else if (index % 3 == 0)
        {
          pastryTotal += _Price - _DealOne;
        }
        else if (index % 6 == 0)
        {
          pastryTotal += _Price - _DealTwo;
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

// Pastry Discount
// 1 = $2
// 3 = $5 $1 off
// 4 = 7 $1 off
// 5 = 9 $1 off
// 6 = 10 $2 off