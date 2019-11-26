using System;
using System.Collections.Generic;
using System.Text;
using Vending_Machine.Data;

namespace Vending_Machine.Model
{
    public class Product
    {
        protected string productName;
        //protected string price;
        //protected string cal;
        protected int cal_int;
        protected int price_int;
        protected int productId;
        
        //public int ProductId { get; protected set; }

        public Product(int productNumber) //Constructor
        {
            ProductNumber = productNumber;
            ProductName = "No input";
            Price=0;
            Cal=0;
        }



        public int ProductNumber
        {
            get
            {
                return productId;
            }
            protected set
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
                if ((value.Length > 0 && value.Length < 30) && value != null)
                {
                    foreach (var item in value)
                    {
                        if (!char.IsLetter(item))
                        {
                            if (item !=' ')
                            checkLetter = false;
                        }
                    }
                    if (checkLetter)
                    {
                        productName = value;
                    }
                    else
                    {
                        throw new ArgumentException("Productname can only contain letters.");
                    }
                }
                else
                {
                    throw new ArgumentException("Productname is too long or short.");
                }

            }
        }

        public int Cal
        {
            get
            {
                return cal_int;
            }

            set
            {               
            if (value >= 0 && value < 1000) //The Calories needs a value, and have a textlength of 1 - 999.
                {
                    cal_int = value;
                }
               
                else if (value == -1)
                {
                    cal_int = 0;
                }

                else
                {
                    throw new ArgumentException("The Calories needs to be between 1 and 999.");
                }

            }
        }

        public int Price
        {
            get
            {
                return price_int;
            }

            set
            {               
            if (value >= 0 && value < 1000) // The int needs a value, no char, and have a textlength of 1 - 3 numbers.
                {
                    price_int = value;
                }
                else
                {
                    throw new ArgumentException("The price needs to be under 1000.");
                }
            }
        }

        public virtual string ShowProductInfo()
        {
           return ($"{productName}, {price_int.ToString()}, {cal_int.ToString()}");
        }
        public virtual string Clear(string stringtoclear)
        {
            return "";
        }

        public override string ToString() //kan vara virtual också
        {
            return $"{productId}: {productName}";
        }
    }
}
