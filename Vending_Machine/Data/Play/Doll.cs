using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class Doll : Toys
    {
        public Doll(int ProductID) : base()
        {
            base.ProductId = ProductSequencer.NextProductId();
            base.battery = false;
            base.ProductName = "Doll";
            base.price_int = 449;
            base.cal_int = -1;
        }
    }
}
