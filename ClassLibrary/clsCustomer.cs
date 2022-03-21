using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        public bool PaymentReceived { get; set; }
        public DateTime DateAdded { get; set; }
        public int CustomerID { get; set; }
        public string HouseNo { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Order { get; set; }
    }
}