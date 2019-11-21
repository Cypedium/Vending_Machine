using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class RC_Car : Toys
    {
        public RC_Car(int ProductNumber) : base()
        {
            base.ProductNumber = ProductSequencer.NextProductNumber();
            base.battery = true;
            base.ProductName = "Best Remote Control Car Ever";
            base.Price = 999;
            base.Cal = 0;
        }
    }
}
