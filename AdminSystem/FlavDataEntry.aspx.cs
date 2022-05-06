using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomers();
            }
        }
    }

    void DisplayCustomers()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        CustomerBook.ThisCustomer.Find(CustomerID);
        txtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        txtCustomerAddress = CustomerBook.ThisCustomer.CustomerAddress;
        txtCustomerName = CustomerBook.ThisCustomer.CustomerName;
        txtCustomerEmail = CustomerBook.ThisCustomer.CustomerEmail;
        txtCustomerOrder = CustomerBook.ThisCustomer.CustomerOrder;
        txtDateAdded = CustomerBook.ThisCustomer.DateAdded.ToString();
        txtPaymentReceived = CustomerBook.ThisCustomer.CustomerPaymentReceived;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsCustomer aCustomer = new clsCustomer();

        string CustomerAddress = txtCustomerAddress.Text;
        string CustomerName = txtCustomerName.Text;
        string CustomerEmail = txtCustomerEmail.Text;
        string CustomerOrder = txtCustomerOrder.Text;
        string DateAdded = txtDateAdded.Text;
        string PaymentReceived = txtPaymentReceived.Text;
        string Error = "";
        Error = aCustomer.Valid(CustomerAddress, CustomerName, CustomerEmail, DateAdded, CustomerOrder);

        if (Error == "")
        {
            aCustomer.CustomerID = CustomerID;
            aCustomer.CustomerAddress = CustomerAddress;
            aCustomer.CustomerEmail = CustomerEmail;
            aCustomer.CustomerName = CustomerName;
            aCustomer.CustomerOrder = CustomerOrder;
            aCustomer.CustomerPaymentReceived = Convert.ToBoolean(txtPaymentReceived.Text);
            aCustomer.DateAdded = Convert.ToDateTime(DateAdded);

            clsCustomerCollection CustomerList = new clsCustomerCollection();
            CustomerList.ThisCustomer = aCustomer;
            CustomerList.Add();
            //Session["aCustomer"] = aCustomer;
            Response.Redirect("FlavList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer aCustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Found = aCustomer.Find(CustomerID);
        if (Found == true)
        {
            txtCustomerAddress.Text = aCustomer.CustomerAddress;
            txtCustomerName.Text = aCustomer.CustomerName;
            txtCustomerOrder.Text = aCustomer.CustomerOrder;
            txtCustomerEmail.Text = aCustomer.CustomerEmail;
            txtPaymentReceived.Text = Convert.ToString(aCustomer.CustomerPaymentReceived);
            txtDateAdded.Text = Convert.ToString(aCustomer.DateAdded);
        }
    }
}