using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class Juice : Drinks
    {
        public Juice(int productNumber) : base(productNumber)
        {           
            base.carbonate = true;
            base.ProductName = "Juice";
            base.Price = 20;
            base.Cal = 345;
        }
    }
}
