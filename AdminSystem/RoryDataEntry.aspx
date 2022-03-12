<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RoryDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblNumber" runat="server" Text="ID Number " width="60px"></asp:Label>
        <asp:TextBox ID="txtNumber" runat="server" OnTextChanged="txtNumber_TextChanged"></asp:TextBox>
        <p>
            <asp:Label ID="lblName" runat="server" Text="Name " width="60px"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="tblPrice" runat="server" Text="Price " width="60px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblDate" runat="server" Text="Date Added " width="60px"></asp:Label>
            <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblAvailable" runat="server" Text="Available "></asp:Label>
        <asp:CheckBox ID="chkAvailable" runat="server" OnCheckedChanged="chkAvailable_CheckedChanged" Text=" " />
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
