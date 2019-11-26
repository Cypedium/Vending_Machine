using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Model
{
    public class Drinks : Product
    {
        protected bool carbonate;
        public Drinks(int productNumber) : base(productNumber)
        {
            carbonate = false;
        }

        public override string ShowProductInfo()
        {
            return ($"{base.ShowProductInfo()}, {carbonate}");
        }
    }
}
