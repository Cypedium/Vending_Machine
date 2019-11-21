using System;
using System.Collections.Generic;
using System.Text;

namespace Vending_Machine.Model
{
    public interface I_Vending_Machine
    {
        // defualt acess level is pulic and "static"
        void AddCurrency(int amount);
        Product Request(int ProductNumber);

        int EndSession();

        string GetDescription(int ProductNumber);

        int GetBalance();

        string[] GetProducts();
       
    }
}
