using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock aStock = new clsStock();
            Assert.IsNotNull(aStock);
        }

        [TestMethod]
        public void AvailbleOK()
        {
            clsStock aStock = new clsStock();

            Boolean TestData = true;

            aStock.Avalible = TestData;

            Assert.AreEqual(aStock.Avalible, TestData);
        }

        [TestMethod]
        public void DateOK()
        {
            clsStock aStock = new clsStock();

            DateTime TestData = DateTime.Now.Date;

            aStock.DateAdded = TestData;

            Assert.AreEqual(aStock.DateAdded, TestData);
        }

        [TestMethod]
        public void IdNumberOK()
        {
            clsStock aStock = new clsStock();

            Int32 TestData = 1;

            aStock.IdNumber = TestData;

            Assert.AreEqual(aStock.IdNumber, TestData);
        }
        [TestMethod]
        public void NameOK()
        {
            clsStock aStock = new clsStock();

            string TestData = "Big Horse";

            aStock.Name = TestData;

            Assert.AreEqual(aStock.Name, TestData);
        }
        [TestMethod]
        public void PriceOK()
        {
            clsStock aStock = new clsStock();

            Int64 TestData = 1000;

            aStock.Price = TestData;

            Assert.AreEqual(aStock.Price, TestData);
        }

    }
}
