using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class Sandwich : Food
    {
        public Sandwich(int ProductNumber) : base()
        {
            base.ProductNumber = ProductSequencer.NextProductNumber();
            base.chocholate = false;
            base.ProductName = "Sandwich";
            base.Price = 99;
            base.Cal = 345;
        }

    }
}
