﻿using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Model;

namespace Vending_Machine.Data
{
    public class Juice : Drinks
    {
        public Juice(int ProductId) : base()
        {
            base.ProductId = ProductSequencer.NextProductId();
            base.carbonate = true;
            base.ProductName = "Juice";
            base.price_int = 20;
            base.cal_int = 345;
        }
    }
}
