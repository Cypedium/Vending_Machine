﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Data
{
    public class ProductSequencer
    {
        
            private static int productId = 0;
            public static int NextProductId()
            {
                return (++productId);
            }

            public static void Reset()
            {
                productId = 0;
            }
        }
    }
}