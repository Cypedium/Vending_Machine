using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Model
{
    public class Drinks : Product
    {
        protected bool carbonate;
        public Drinks() : base()
        {
            carbonate = false;
        }

        public override string ShowProductInfo()
        {
            return ($"{productName}, {price_int.ToString()}, {cal_int.ToString()}, {carbonate}");
        }
    }
}
