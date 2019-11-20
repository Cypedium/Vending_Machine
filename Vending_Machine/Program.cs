using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Model;
using Vending_Machine.Data;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            RC_Car acar = new RC_Car(3);
            
            
            Console.WriteLine(acar.ShowProductInfo());
        }
    }
}
