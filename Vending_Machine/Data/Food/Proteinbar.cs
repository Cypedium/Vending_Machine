using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class Proteinbar : Food
    {
        public Proteinbar(int ProductId) : base()
        {
            base.ProductId = ProductSequencer.NextProductId();
            base.chocholate = true;
            base.ProductName = "Proteinbar";
            base.price_int = 45;
            base.cal_int = 299;
        }
    }
}
