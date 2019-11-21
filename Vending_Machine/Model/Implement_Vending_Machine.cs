using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Model
{
    
    public class Implement_Vending_Machine : I_Vending_Machine
    {
        public int NewAmount { get; set; }
        public static void AddCurrency(int amount)
        {
            amount = amount + NewAmount;
        }
        
    }
}
