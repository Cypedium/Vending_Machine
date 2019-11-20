using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class Sandwich : Food
    {
        public Sandwich(int ProductId) : base()
        {
            base.ProductId = ProductSequencer.NextProductId();
            base.chocholate = false;
            base.ProductName = "Sandwich";
            base.price_int = 99;
            base.cal_int = 345;
        }

    }
}
