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

        public void CreateProduct_ok()
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
        [Fact]
        public void ShowProductInfo_ok()
        {
            //Arrange
            string testcoke = "Coke, 20, 345, False";
            string testproteinbar = "Proteinbar, 45, 299, True";
            string testRC_Car = "Best Remote Control Car Ever, 999, 0, True";
            //Assert
            
            Coke aCoke = new Coke(ProductSequencer.NextProductId());
            Proteinbar abar = new Proteinbar(ProductSequencer.NextProductId());
            RC_Car aCar = new RC_Car(ProductSequencer.NextProductId());


            //Act
            Assert.Equal(testcoke,aCoke.ShowProductInfo());
            Assert.Equal(testproteinbar,abar.ShowProductInfo());
            Assert.Equal(testRC_Car,aCar.ShowProductInfo());
        }
        [Fact]
        public void ClearInfo_ok()
        {
            //Assigne
            string testempty = "";

            //Assert
            Coke aCoke_ = new Coke(ProductSequencer.NextProductId());

            //Act
            Assert.Equal(testempty, aCoke_.Clear(aCoke_.ShowProductInfo()));
        }
    }
}
