using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class RC_Car : Toys
    {
        public RC_Car(int ProductID) : base()
        {
            base.ProductId = ProductSequencer.NextProductId();
            base.battery = true;
            base.ProductName = "RC_Car";
            base.price_int = 999;
            base.cal_int = -1;
        }
    }
}
