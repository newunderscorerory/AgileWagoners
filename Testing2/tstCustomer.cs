using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(aCustomer);
        }

        [TestMethod]
        public void PaymentReceivedOK()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data of the property
            aCustomer.PaymentReceived = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.PaymentReceived, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            aCustomer.DateAdded = TestData;
            Assert.AreEqual(aCustomer.DateAdded, TestData);
        }

        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            Int32 TestData = 1;
            aCustomer.CustomerID = TestData;
            Assert.AreEqual(aCustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "21b";
            aCustomer.HouseNo = TestData;
            Assert.AreEqual(aCustomer.HouseNo, TestData);
        }

        [TestMethod]
        public void PostCodePropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "LE1 4AB";
            aCustomer.PostCode = TestData;
            Assert.AreEqual(aCustomer.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "Street";
            aCustomer.Street = TestData;
            Assert.AreEqual(aCustomer.Street, TestData);
        }

        [TestMethod]
        public void TownPropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "Leicester";
            aCustomer.Town = TestData;
            Assert.AreEqual(aCustomer.Town, TestData);
        }

        [TestMethod]
        public void CustomerFirstNameOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "Flavio";
            aCustomer.FirstName = TestData;
            Assert.AreEqual(aCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void CustomerLastNameOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "Santos";
            aCustomer.LastName = TestData;
            Assert.AreEqual(aCustomer.LastName, TestData);
        }

        [TestMethod]
        public void CustomerEmailOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "email@email.com";
            aCustomer.Email = TestData;
            Assert.AreEqual(aCustomer.Email, TestData);
        }

        [TestMethod]
        public void CustomerOrderOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "1 Big Horse";
            aCustomer.Order = TestData;
            Assert.AreEqual(aCustomer.Order, TestData);
        }
    }
}
