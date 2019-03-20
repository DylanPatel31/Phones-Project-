<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCustomerMain.aspx.cs" Inherits="FrontEnd.frmCustomerMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #FFCC99">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="btnFilterbyPostcode" runat="server" style="z-index: 1; left: 75px; top: 513px; position: absolute; height: 38px; width: 281px;" Text="Filter by PostCode" OnClick="btnFilterbyPostcode_Click" BackColor="#00FFCC" Font-Bold="True" Font-Size="Medium" />
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 73px; top: 455px; position: absolute; width: 275px; height: 29px;" BackColor="#CCCC00" Font-Bold="True" Font-Size="Medium"></asp:TextBox>
        <asp:ListBox ID="lstCust" runat="server" style="z-index: 1; left: 71px; top: 96px; position: absolute; height: 289px; width: 583px; background-color: #FFFF99;"></asp:ListBox>
        <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 700px; top: 93px; position: absolute; width: 182px; height: 42px;" Text="Edit Customer" OnClick="btnEdit_Click" BackColor="#00CCFF" Font-Bold="True" Font-Size="Medium" />
        <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 700px; top: 211px; position: absolute; width: 183px; height: 41px;" Text="Add Customer" OnClick="btnAdd_Click" BackColor="#CC6600" Font-Bold="True" Font-Size="Medium" />
        <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 699px; top: 341px; position: absolute; height: 40px; width: 189px;" Text="Delete Customer" OnClick="btnDelete_Click" BackColor="#FF6600" Font-Bold="True" Font-Size="Medium" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 980px; top: 542px; position: absolute" Text="lblError"></asp:Label>
        <asp:Label ID="lblTitle" runat="server" style="z-index: 1; left: 236px; top: 35px; position: absolute; height: 37px; width: 197px" Text="Display Customers" BackColor="White" Font-Bold="True" Font-Size="X-Large"></asp:Label>
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" style="z-index: 1; left: 526px; top: 448px; position: absolute; width: 135px; height: 37px;" Text="DisplayAll" BackColor="#CC3300" Font-Bold="True" Font-Size="Medium" />
        <asp:Label ID="lblEnterPostCode" runat="server" Font-Bold="True" Font-Size="Large" style="z-index: 1; left: 70px; top: 409px; position: absolute; height: 32px" Text="Please Enter a Customer's Post Code"></asp:Label>
    </form>
</body>
</html>
