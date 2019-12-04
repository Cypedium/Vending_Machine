using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Vending_Machine.Model;
using Vending_Machine.Data;
using System.Linq;

namespace XUnitTest_Vending_Machine
{
    public class UnitTest_VendingMachine
    {      
        [Fact]
        public void AddCurrency_ok()
        {
            //Arrange
            int testamount1 = 1000;

            //Assert
            Implement_Vending_Machine myVendingMachine1 = new Implement_Vending_Machine();
            myVendingMachine1.AddCurrency(testamount1);


            //Act
            Assert.Equal(testamount1, myVendingMachine1.GetBalance());
        }

        [Fact]
        public void AddCurrency_wrong()
        {
            //Arrange
            int testamount1 = 1001;
            string expected_error_msg = "Wrong input amount.";
            string error_msg = "";
            //Assert
            Implement_Vending_Machine myVendingMachine2 = new Implement_Vending_Machine();
            try
            {
                myVendingMachine2.AddCurrency(testamount1);
            }

            catch (FormatException exception)
            {
                error_msg = exception.Message;
            }
            //Act
            Assert.Equal(expected_error_msg, error_msg);

        }
        [Fact]
        public void EndSession_ok()
        {
            //Arrange
            int testAmount1 = 1000;
            int testAmount2 = 500;
            int testAmount3 = 100;
            int testAmount4 = 50;
            int testAmount5 = 20;
            int testAmount6 = 5;
            int testAmount7 = 1;
            int sumTestAmount = 1776;

            //Assert
            Implement_Vending_Machine myVendingMachine3 = new Implement_Vending_Machine();
            myVendingMachine3.AddCurrency(testAmount1);
            myVendingMachine3.AddCurrency(testAmount2);
            myVendingMachine3.AddCurrency(testAmount3);
            myVendingMachine3.AddCurrency(testAmount3);
            myVendingMachine3.AddCurrency(testAmount4);
            myVendingMachine3.AddCurrency(testAmount5);
            myVendingMachine3.AddCurrency(testAmount6);
            myVendingMachine3.AddCurrency(testAmount7);

            //Act
            Assert.Equal(sumTestAmount, myVendingMachine3.GetBalance());
        }
        [Fact]
        public void UpdateMoneyPool()
        {
            //Arrange
            int testAmount1 = 1000;
            int testAmount2 = 500;
            int testAmount3 = 100;
            int testAmount4 = 50;
            int testAmount5 = 20;
            int testAmount6 = 5;
            int testAmount7 = 1;
            int sumTestAmount = 1776;

            //Assert
            Implement_Vending_Machine myVendingMachine4 = new Implement_Vending_Machine();
            myVendingMachine4.AddCurrency(testAmount1);
            myVendingMachine4.AddCurrency(testAmount2);
            myVendingMachine4.AddCurrency(testAmount3);
            myVendingMachine4.AddCurrency(testAmount3);
            myVendingMachine4.AddCurrency(testAmount4);
            myVendingMachine4.AddCurrency(testAmount5);
            myVendingMachine4.AddCurrency(testAmount6);
            myVendingMachine4.AddCurrency(testAmount7);

            //Act
            Assert.Equal(sumTestAmount, myVendingMachine4.UpdateMoneypool().Sum());
            Assert.Equal(sumTestAmount, myVendingMachine4.GetBalance());
        }

        [Fact]
        public void GetDescription_ok()
        {
            //Arrange
            int testId1 = 1;
            string actual_description = "";
            string expected_description = "Coke, 20, 345, False";

            //Assert
            Implement_Vending_Machine myVendingMachine5 = new Implement_Vending_Machine();
            actual_description = myVendingMachine5.GetDescription(testId1);
            //Act
            Assert.Equal(expected_description, actual_description);
        }

        [Fact]
        public void GetProducts_ok()
        {
            
            //Arrange           
            
            
            string[] actual_description = new string[6];

            //Assert
            Implement_Vending_Machine myVendingMachine6 = new Implement_Vending_Machine();
            actual_description = myVendingMachine6.GetProducts();
            //Act                       
                Assert.Contains("1 : Coke", actual_description);
                Assert.Contains("2 : Juice", actual_description);
                Assert.Contains("3 : Proteinbar", actual_description);
                Assert.Contains("4 : Sandwich", actual_description);
                Assert.Contains("5 : Doll", actual_description);
                Assert.Contains("6 : RC Car", actual_description);
            
        }

        [Fact]
        public void Request_ok()
        {
            //Asigne
           
            Implement_Vending_Machine myVendingMachine6 = new Implement_Vending_Machine();

            Product requested_product = new Coke(int.MaxValue);

            //Assert
            Product actual_product = myVendingMachine6.Request(int.MaxValue);


            //Act
            Assert.Equal(requested_product, actual_product);
        }

    }
}
