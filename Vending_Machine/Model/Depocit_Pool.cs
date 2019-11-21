using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Model
{
    public class Depocit_Pool
    {
        
        public int[] CalcDepocit_Pool(int amount)
        {
            
            int[] moneyArray = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
            int[] depocitArray = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            

            while (amount!= 0)
            {

                for (int i = 0; i < 8; i++)
                {
                    if (amount >= moneyArray[i])
                    {
                        amount = amount - moneyArray[i];
                        depocitArray[i]++;
                        break;
                    }

                }
            }
            return depocitArray;
        }
    }
}
