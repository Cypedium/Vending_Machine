using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Vending_Machine.Model;
using Vending_Machine.Data;

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
            Implement_Vending_Machine myVendingMachine = new Implement_Vending_Machine();
            myVendingMachine.AddCurrency(testamount1);
           

            //Act
            Assert.Equal(testamount1, myVendingMachine.GetBalance());
        }

        [Fact]
        public void AddCurrency_wrong()
        {
            //Arrange
            int testamount1 = 1001;
            string expected_error_msg = "Wrong input amount.";
            string error_msg="";
            //Assert
            Implement_Vending_Machine myVendingMachine = new Implement_Vending_Machine();
            try
            {
                myVendingMachine.AddCurrency(testamount1);
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
            int testAmount7 = 2;
            int sumTestAmount = 1777;

            //Assert
            Implement_Vending_Machine myVendingMachine = new Implement_Vending_Machine();
            myVendingMachine.AddCurrency(testAmount1);
            myVendingMachine.AddCurrency(testAmount2);
            myVendingMachine.AddCurrency(testAmount3);
            myVendingMachine.AddCurrency(testAmount3);
            myVendingMachine.AddCurrency(testAmount4);
            myVendingMachine.AddCurrency(testAmount5);
            myVendingMachine.AddCurrency(testAmount6);
            myVendingMachine.AddCurrency(testAmount7);

            //Act
            Assert.Equal(sumTestAmount, myVendingMachine.GetBalance());
        }

        //[Fact]
        //public int GetBalance_ok()
        //{

        //}
        //[Fact]
        //public string GetDescription_ok(int ProductNumber)
        //{

        //}
        //[Fact]
        //public string[] GetProducts_ok()
        //{

        //}
        //[Fact]
        //public Product Request_ok(int ProductNumber)
        //{

        //}

    }
}
