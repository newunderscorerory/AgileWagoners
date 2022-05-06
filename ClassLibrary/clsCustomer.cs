using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomer
    {

        private Int32 mCustomerID;
        private bool mCustomerPaymentReceived;
        public bool CustomerPaymentReceived
        {
            get
            {
                return mCustomerPaymentReceived;
            }
            set
            {
                mCustomerPaymentReceived = value;
            }
        }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        
        }
        public int CustomerID {
            get
            {
                return mCustomerID;
            }
            set
            {
                mCustomerID = value;
            }
         }
        private string mCustomerAddress;
        public string CustomerAddress
        {
            get
            {
                return mCustomerAddress;
            }
            set
            {
                mCustomerAddress = value;
            }
        }
        private string mCustomerName;
        public string CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
            }
        }
        private string mCustomerEmail;
        public string CustomerEmail
        {
            get
            {
                return mCustomerEmail;
            }
            set
            {
                mCustomerEmail = value;
            }
        }
        private string mCustomerOrder;
        public string CustomerOrder
        {
            get
            {
                return mCustomerOrder;
            }
            set
            {
                mCustomerOrder = value;
            }
        }

        public bool Find(int CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            if (DB.Count == 1)
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mCustomerAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mCustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mCustomerPaymentReceived = Convert.ToBoolean(DB.DataTable.Rows[0]["PaymentReceived"]);
                mCustomerOrder = Convert.ToString(DB.DataTable.Rows[0]["CustomerOrder"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Valid(string address, string name, string email, string dateAdded, string order)
        {
            String Error = "";
            DateTime DateTemp;
            if (address.Length == 0)
            {
                Error = Error + "The Address may not be blank : ";
            }

            if (address.Length > 50)
            {
                Error = Error + "The address must be less than 50 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not valid : ";
            }

            if (name.Length == 0)
            {
                Error = Error + "The name may not be blank : ";
            }

            if (name.Length > 50)
            {
                Error = Error + "The name must be less than 50 characters : ";
            }

            if (order.Length == 0)
            {
                Error = Error + "The order may not be blank : ";
            }

            if (order.Length > 50)
            {
                Error = Error + "The order must be less than 50 characters : ";
            }

            if (email.Length == 0)
            {
                Error = Error + "The email may not be blank : ";
            }

            if (email.Length > 50)
            {
                Error = Error + "The email must be less than 50 characters : ";
            }
            return Error;

        }
    }
}