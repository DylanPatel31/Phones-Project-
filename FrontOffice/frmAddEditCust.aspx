<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmAddEditCust.aspx.cs" Inherits="FrontEnd.frmAddEditCust" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 35px; top: 88px; position: absolute; width: 42px" Text="Title"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 33px; top: 126px; position: absolute" Text="First Name"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" style="z-index: 1; left: 33px; top: 165px; position: absolute" Text="Last Name"></asp:Label>
        <asp:Label ID="lblHouseNo" runat="server" style="z-index: 1; left: 33px; top: 202px; position: absolute" Text="House No"></asp:Label>
        <asp:Label ID="lblTown" runat="server" style="z-index: 1; left: 35px; top: 244px; position: absolute" Text="Town"></asp:Label>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 34px; top: 283px; position: absolute" Text="PostCode"></asp:Label>
        <asp:Label ID="lblContactNo" runat="server" style="z-index: 1; left: 31px; top: 319px; position: absolute" Text="ContactNo"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" style="z-index: 1; left: 34px; top: 357px; position: absolute" Text="Email"></asp:Label>
        <asp:Label ID="lblDateofBirth" runat="server" style="z-index: 1; left: 30px; top: 394px; position: absolute" Text="Date Of Birth"></asp:Label>
        <asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; left: 132px; top: 91px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 134px; top: 129px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 133px; top: 165px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtHouseNo" runat="server" style="z-index: 1; left: 133px; top: 203px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTown" runat="server" style="z-index: 1; left: 133px; top: 244px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 133px; top: 282px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtContactNo" runat="server" style="z-index: 1; left: 133px; top: 318px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 131px; top: 357px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateOfBirth" runat="server" style="z-index: 1; left: 132px; top: 393px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 132px; top: 432px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 28px; top: 431px; position: absolute">Date Added</asp:Label>
        <asp:Button ID="btnEnter" runat="server" style="z-index: 1; left: 132px; top: 505px; position: absolute; width: 80px" Text="Enter" OnClick="btnEnter_Click" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 463px; top: 510px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 294px; top: 507px; position: absolute; height: 26px" Text="Cancel" />
        <asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; left: 133px; top: 52px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomer" runat="server" style="z-index: 1; left: 36px; top: 53px; position: absolute" Text="CustomerNo"></asp:Label>
    </form>
</body>
</html>
