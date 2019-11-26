using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class Doll : Toys
    {
        public Doll(int productNumber) : base(productNumber)
        {          
            base.battery = false;
            base.ProductName = "Doll";
            base.Price = 449;
            base.Cal = 0;
        }
    }
}
