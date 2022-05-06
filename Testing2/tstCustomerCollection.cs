using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void AddressListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.CustomerAddress = "7 Kirby Road";
            TestItem.CustomerEmail = "email@gmail.com";
            TestItem.CustomerOrder = "3 Horses";
            TestItem.CustomerPaymentReceived = false;

            TestList.Add(TestItem);

            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestItem);
        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestAddress = new clsCustomer();

            TestAddress.CustomerID = 1;
            TestAddress.DateAdded = DateTime.Now.Date;
            TestAddress.CustomerAddress = "7 Kirby Road";
            TestAddress.CustomerEmail = "email@gmail.com";
            TestAddress.CustomerOrder = "3 Horses";
            TestAddress.CustomerPaymentReceived = false;

            AllCustomers.ThisCustomer = TestAddress;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestAddress);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            List<clsCustomer> TestList = new List<clsCustomer>();

            clsCustomer TestItem = new clsCustomer();
            TestItem.CustomerID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.CustomerAddress = "7 Kirby Road";
            TestItem.CustomerEmail = "email@gmail.com";
            TestItem.CustomerOrder = "3 Horses";
            TestItem.CustomerPaymentReceived = false;

            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;

            TestItem.CustomerID = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.CustomerAddress = "7 Kirby Road";
            TestItem.CustomerName = "Flav Santos";
            TestItem.CustomerEmail = "email@gmail.com";
            TestItem.CustomerOrder = "3 Horses";
            TestItem.CustomerPaymentReceived = false;

            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.CustomerAddress = "7 Kirby Road";
            TestItem.CustomerName = "Flav Santos";
            TestItem.CustomerEmail = "email@gmail.com";
            TestItem.CustomerOrder = "3 Horses";
            TestItem.CustomerPaymentReceived = false;
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();

            TestItem.CustomerID = PrimaryKey;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.CustomerAddress = "70 Kirby Road";
            TestItem.CustomerName = "Flavioo Santos";
            TestItem.CustomerEmail = "email2@gmail.com";
            TestItem.CustomerOrder = "4 Horses";
            TestItem.CustomerPaymentReceived = false;
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
    }
}
