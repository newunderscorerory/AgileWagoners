<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlavDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerID" runat="server" Text="Customer Number"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerID" runat="server" style="margin-left: 0px" Width="158px"></asp:TextBox>
        &nbsp;<asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </div>
        <asp:Label ID="lblCustomerAddress" runat="server" Text="Address" width="143px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerAddress" runat="server" width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerName" runat="server" Text="Full Name" width="143px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerName" runat="server" width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerEmail" runat="server" Text="Email" width="143px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerEmail" runat="server" width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="lblCustomerOrder" runat="server" Text="Order" width="143px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerOrder" runat="server" width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Text="Date Added" width="143px"></asp:Label>
&nbsp;<asp:TextBox ID="txtDateAdded" runat="server" width="166px"></asp:TextBox>
        <br />
        <asp:Label ID="lblPaymentReceived" runat="server" Text="Payment Received" width="143px"></asp:Label>
&nbsp;<asp:TextBox ID="txtPaymentReceived" runat="server" width="166px"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
