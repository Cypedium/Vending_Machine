using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class RC_Car : Toys
    {
        public RC_Car(int productNumber) : base(productNumber)
        {
           
            base.battery = true;
            base.ProductName = "RC Car";
            base.Price = 999;
            base.Cal = 0;
        }
    }
}
