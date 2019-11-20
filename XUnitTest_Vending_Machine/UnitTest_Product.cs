using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Vending_Machine.Model;
using Vending_Machine.Data;

namespace XUnitTest_Vending_Machine
{
    public class UnitTest_Product
    {
        [Fact]

        public void AddnewProduct()
        {
            //Arrange
            int testid1 = 1;
            int testid2 = 2;
            int testid3 = 3;
            //Assert
            Coke cocacola = new Coke(testid1);
            Proteinbar proteinbar = new Proteinbar(testid2);
            Doll doll = new Doll(testid3);
            //Act
            Assert.Equal(testid1, cocacola.ProductId);
            Assert.Equal(testid2, proteinbar.ProductId);
            Assert.Equal(testid3, doll.ProductId);
        }

    }
}
