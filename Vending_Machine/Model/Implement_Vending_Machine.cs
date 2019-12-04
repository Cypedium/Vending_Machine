using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;
using System.Linq;

namespace Vending_Machine.Model
{

    public class Implement_Vending_Machine : IVending_Machine
    {
        protected int amount = 0;

        public Implement_Vending_Machine()
        {

        }

        public Implement_Vending_Machine(Product[] products)
        {
            productArray = products;
        }
        
        //Create all products

        public static Product[] productArray = new Product[]
        {
        new Coke(ProductSequencer.NextProductNumber()),
        new Juice(ProductSequencer.NextProductNumber()),
        new Proteinbar(ProductSequencer.NextProductNumber()),
        new Sandwich(ProductSequencer.NextProductNumber()),
        new Doll(ProductSequencer.NextProductNumber()),
        new RC_Car(ProductSequencer.NextProductNumber())
        };

        public void AddCurrency(int newamount)
        {

            int[] newAmountArray = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
            bool wrongAmount = true;


            for (int i = 0; i < 8; i++)
            {
                if (newamount == newAmountArray[i])
                {
                    amount += newAmountArray[i];
                    wrongAmount = false;
                    break;
                }

                if (wrongAmount)
                {
                    throw new FormatException("Wrong input amount.");
                }
            }
        }
          
      

        public int[] EndSession()
        {
            return UpdateMoneypool();           
        }

        public int[] UpdateMoneypool()
        {
            int[] moneyArray = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
            int[] depocitArray = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            int amountlokal = amount;

            while (amountlokal != 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (amountlokal >= moneyArray[i])
                    {
                        depocitArray[i] += moneyArray[i];
                        amountlokal -= moneyArray[i];
                        if (amountlokal >= moneyArray[i]) //Kollar om amountlokal behöver köras en gång till på samma nivå
                        { i--; }
                    }
                }
                return depocitArray;
            }
            throw new Exception("The money array is empty.");
        }

        public int GetBalance()
        {

            return UpdateMoneypool().Sum();
        }

        public string GetDescription(int productNumber)
        {  
            for (int i = 0; i < productArray.Length; i++)
            {
                if (productNumber == productArray[i].ProductNumber) //i array ligger aCar.ProductNumber
                {
                    return productArray[i].ShowProductInfo();
                }      
            }
            throw new Exception("The Productnumber doesn't exist!");
        }

        public string[] GetProducts()
        {
            if (productArray.Length > 0)
            {
                string[] getProductArray = new string[productArray.Length];
                for (int i = 0; i < productArray.Length; i++)
                {
                     getProductArray[i] = productArray[i].ProductNumber.ToString() + " : " + productArray[i].ProductName;                    
                }
                return getProductArray;
            }
            else
            {
                throw new Exception("The product array is empty.");          
            }       
        }

        public Product Request(int ProductNumber) //Buy a product
        {
            for (int i = 0; i < productArray.Length; i++)
            {
                if (ProductNumber==productArray[i].ProductNumber)
                    {
                        return productArray[i];
                    }   
            }
            throw new Exception("The Product array is empty.");
        }    
    }
}
