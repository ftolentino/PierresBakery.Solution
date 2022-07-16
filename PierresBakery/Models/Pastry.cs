using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    // properties
    public int Quantity { get; set; }
    // Pastry constructor
    public Pastry(int quantity)
    {
      Quantity = quantity;
    }
  }
}