using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;

namespace Vending_Machine.Model
{
    public class Product
    {
        private string productName;
        private int price;
        private int cal;
        private int productId;
        public int ProductId
        {
            get
            {
                return ProductId;
            }
            private set
            {
                productId = value;
            }
        }
        public string ProductName
        {
            get
            {
                return productName;
            }

            set
            {
                bool checkLetter = true; //The string needs a value, and have a textlength of 1-29 chars. 
                if (value.Length > 0 && value.Length < 30 && value != null)
                {
                    foreach (var item in value)
                    {
                        if (!char.IsLetter(item))
                        {
                            checkLetter = false;
                        }
                    }
                    if (checkLetter)
                    {
                        productName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Name can only contain letters.");
                    }
                }
                else
                {
                    throw new ArgumentException("Name is too long or short.");
                }
            }
        }

        public int Cal
        {
            get
            {
                return cal;
            }

            set
            {
                //The int needs a value, no char, and have a textlength of 1-3 numbers.
                if (value > 1 && value < 4 && value != 0)
                {
                    cal = value;
                }

                else if (value == 0)
                {
                    throw new ArgumentException("The value can not be 0 och characters");
                }

                else
                {
                    throw new ArgumentException("Cal need to be two or three numbers");
                }
            }                             
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                //The int needs a value, no char, and have a textlength of 1-3 numbers.
                if (value > 1 && value < 4 && value != 0)
                {
                    price = value;
                }

                else if (value == 0)
                {
                    throw new ArgumentException("The value can not be 0 och characters");
                }

                else
                {
                    throw new ArgumentException("Cal need to be two or three numbers");
                }
            }
        }

        public Product (string productName, int cal, int price) //Constructor
        {
            ProductId = ProductSequencer.NextProductId(); //Uses PersonSequencer to get next id. 
            ProductName = productName;
            Price = price;
            Cal = cal;
        }
    }
}
