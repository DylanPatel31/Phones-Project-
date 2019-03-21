<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="FrontEnd.Delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #66FFFF">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblDelete" runat="server" style="z-index: 1; left: 116px; top: 151px; position: absolute; height: 29px; width: 301px"></asp:Label>
        <asp:Button ID="btnYes" runat="server" style="z-index: 1; left: 103px; top: 253px; position: absolute; height: 34px; width: 130px" Text="Yes" BackColor="#FF5050" BorderColor="Red" OnClick="btnYes_Click" Font-Bold="True" Font-Size="Medium" />
        <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 369px; top: 251px; position: absolute; height: 37px; width: 130px" Text="No" BackColor="#CCCC00" OnClick="btnNo_Click" Font-Bold="True" Font-Size="Medium" />
    </form>
</body>
</html>
