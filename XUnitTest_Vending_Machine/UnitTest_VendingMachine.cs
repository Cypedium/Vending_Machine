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
            int testamount2 = 1001;
            string error_msg = "Wrong input amount.";

            //Assert
            

            //Act
            Assert.Equal(error_msg, Product.AddCurrency(testamount2));
            Assert.Equal(, AddCurrency(testamount1));
            

        }
        //[Fact]
        //public void AddCurrency_wrong(int amount)
        //{
            
        //}
        //[Fact]
        //public int[] EndSession_ok()
        //{
           
        //}

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
