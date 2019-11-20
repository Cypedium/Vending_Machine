using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;

namespace Vending_Machine.Model
{
    public class Food : Product
    {
        protected bool chocholate;

        public  Food () : base ()
        {
            chocholate = false;
        }
        public override string ShowProductInfo()
        {
            return ($"{productName}, {price_int.ToString()}, {cal_int.ToString()}, {chocholate}");
        }
    }

}
