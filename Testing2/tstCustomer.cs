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
            aCustomer.CustomerPaymentReceived = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(aCustomer.CustomerPaymentReceived, TestData);
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
        public void CustomerAddressPropertyOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "93 Pendleton";
            aCustomer.CustomerAddress = TestData;
            Assert.AreEqual(aCustomer.CustomerAddress, TestData);
        }

        [TestMethod]
        public void CustomerNameOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "Flavio Moreira";
            aCustomer.CustomerName = TestData;
            Assert.AreEqual(aCustomer.CustomerName, TestData);
        }

        [TestMethod]
        public void CustomerEmailOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "email@email.com";
            aCustomer.CustomerEmail = TestData;
            Assert.AreEqual(aCustomer.CustomerEmail, TestData);
        }

        [TestMethod]
        public void CustomerOrderOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            string TestData = "1 Big Horse";
            aCustomer.CustomerOrder = TestData;
            Assert.AreEqual(aCustomer.CustomerOrder, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomer aCustomer = new clsCustomer();
            //Bollean variable to store the results of the validation
            Boolean Found = false;

            Int32 CustomerID = 1;

            Found = aCustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIDFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.CustomerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);
            if (aCustomer.DateAdded != Convert.ToDateTime("12/03/2022"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);

            if (aCustomer.CustomerAddress != "7 Kirby Road")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);

            if (aCustomer.CustomerName != "Flavio Moreira")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerEmailFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);

            if (aCustomer.CustomerEmail != "email@gmail.com")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerOrderFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);

            if (aCustomer.CustomerOrder != "3 Horses")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerPaymentReceivedFound()
        {
            clsCustomer aCustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 1;
            Found = aCustomer.Find(CustomerID);

            if (aCustomer.CustomerPaymentReceived != false)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }




    }
}
