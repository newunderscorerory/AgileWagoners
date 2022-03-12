using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void chkAvailable_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStock aStock = new clsStock();


        aStock.Name = txtName.Text;
        Session["aStock"] = aStock;
        Response.Redirect("RoryViewer.aspx");

        aStock.Price = txtPrice.Text;
        Session["aStock"] = aStock;
        Response.Redirect("RoryViewer.aspx");

        aStock.IdNumber = txtIdNumber.Text;
        Session["aStock"] = aStock;
        Response.Redirect("RoryViewer.aspx");

        aStock.DateAdded = txtDate.Text;
        Session["aStock"] = aStock;
        Response.Redirect("RoryViewer.aspx");

        aStock.Avalible = chkAvailable.Text;
        Session["aStock"] = aStock;
        Response.Redirect("RoryViewer.aspx");

    }
}