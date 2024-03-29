using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadOrder { get; set; }
    public  int BreadPriceTotal => GetBreadPrice(BreadOrder);
    public Bread(int breadOrder)
    {
      BreadOrder = breadOrder;
    }
    public int GetBreadPrice(int BreadOrder)
    {
      int breadPrice = 5;
       if (BreadOrder % 3 == 0)
      {
     
        breadPrice = (breadPrice * BreadOrder) - ((BreadOrder / 3) * 5);
      }
      else if (BreadOrder % 3 != 0 && BreadOrder > 3) {
        breadPrice = (breadPrice * BreadOrder) - ((BreadOrder / 3) * 5) + (BreadOrder % 3 * 5);
      }
      else
      {
        breadPrice *= BreadOrder;
      }
      return breadPrice;
    }
  }
}