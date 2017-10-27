using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace ForUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calculate_PlayerChoices_ReturnsCalculatedScore()
        {
            //Arrange
            Day day = new Day();
            day.weather.cloudType = "sunny";
            int expectedResult = 120;

            //Act
            day.determineNumberOfCustomers();

            //Assert
            Assert.AreEqual(expectedResult, day.numberOfCustomers);
        }

        [TestMethod]
        public void getNewCustomer()
        {
            //Arrange
            Day day = new Day();
            day.Customers. = new Customer();
            int expectedResult = l

            //Act
            day.setPrices;

            //Assert
            Assert.AreEqual(expectedResult, day.numberOfCustomers);
        }
    }
}