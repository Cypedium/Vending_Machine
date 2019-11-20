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
    }
}
