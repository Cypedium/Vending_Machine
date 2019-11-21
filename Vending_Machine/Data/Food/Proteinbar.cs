using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class Proteinbar : Food
    {
        public Proteinbar(int ProductNumber) : base()
        {
            base.ProductNumber = ProductSequencer.NextProductNumber();
            base.chocholate = true;
            base.ProductName = "Proteinbar";
            base.Price = 45;
            base.Cal = 299;
        }
    }
}
