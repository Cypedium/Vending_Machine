using System;
using Xunit;

namespace XUnitTest_Vending_Machine
{
    public class UnitTest_Product
    {
        [Fact]
        public void CreateProduct_ok()
        {
            //Arrange
            string firstName = "testfirstname";
            string lastName = "testlastname";

            //Act
            Person testPerson = new Person(firstName, lastName);

            //Assert
            Assert.Equal(firstName, testPerson.FirstName);
            Assert.Equal(lastName, testPerson.LastName);

        }
    }
}
