using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Data
{
    public class ProductSequencer
    {
        
            protected static int productNumber = 0;
            public static int NextProductNumber()
            {
                return (++productNumber);
            }

            public static void Reset()
            {
                productNumber = 0;
            }
        
    }
}
