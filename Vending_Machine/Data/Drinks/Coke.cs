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
            base.price_int = 20;
            base.cal_int = 345;
        }
    }
}
