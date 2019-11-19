using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;

namespace Vending_Machine.Model
{
    public class Food : Product
    {
        public bool chocholate=false;

        public override Food(bool chocholate, string productName, string cal, string price) : base (productName, cal, price)
        {
            base.ProductId = ProductSequencer.NextProductId(); //Uses ProductSequencer to get next id. 
            base.ProductName = productName;
            base.Price = int.Parse(price);
            base.Cal = int.Parse(cal);

        }
    }
}
