using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class Coke : Drinks
    {
        public Coke(int ProductId) : base()
        {
            base.ProductId = ProductSequencer.NextProductId();
            base.carbonate = false;
            base.ProductName = "Coke";
            base.Price = 20;
            base.Cal = 345;
        }
    }
}
