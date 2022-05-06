using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        string Address = "93 Pendleton";
        string Name = "Flavio Andre";
        string Email = "tester@gmail.com";
        string DateAdded = DateTime.Now.Date.ToString();
        string Order = "10 Horses";
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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AddressMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Address = "a";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }
        
        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Address = "aa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }
        
        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }
        
        [TestMethod]
        public void AddressMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }
        
        [TestMethod]
        public void AddressMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Address = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void AddressExtremeMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(500, 'a');
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string DateAdded = "Date";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Name = "";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void NameMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Name = "a";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Name = "aa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NameMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NameMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(500, 'a');
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderMinLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Order = "";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Order = "a";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Order = "aa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderMaxLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Order = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Order = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Order = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Order = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderExtremeMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Order = "";
            Order = Order.PadRight(500, 'a');
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailMin()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Email = "a";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Email = "aa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMid()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Email = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer aCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(500, 'a');
            Error = aCustomer.Valid(Address, Name, Email, DateAdded, Order);
            Assert.AreNotEqual(Error, "");
        }


    }
}
