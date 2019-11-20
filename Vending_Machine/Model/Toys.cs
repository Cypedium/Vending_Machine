using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Model
{
    public class Toys : Product
    {
        protected bool battery;
       public Toys() : base()
        {
            battery = false;
        }

        public override string ShowProductInfo()
        {
            return ($"{productName}, {price_int.ToString()}, {cal_int.ToString()}, {battery}");
        }

    }
}
