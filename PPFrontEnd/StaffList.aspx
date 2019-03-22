<%@ Page Title="" Language="C#" MasterPageFile="~/Phones.Master" AutoEventWireup="true" CodeBehind="StaffList.aspx.cs" Inherits="PPFrontEnd.StaffList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /> 
    <br />
    <asp:ListBox ID="lstStaff" runat="server" style="z-index: 1; height: 197px; width: 327px"></asp:ListBox>
    <br />
    <asp:Label ID="lblError" runat="server" style="z-index: 1; width: 393px"></asp:Label>
    <br /> 
    <br />
    <br />
    <asp:Label ID="lblLastName" runat="server" style="z-index: 1; width: 317px" Text="Please Enter a Last Name"></asp:Label>
    <br />
    <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; width: 280px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnApply" runat="server" style="z-index: 1; width: 119px" Text="Apply" OnClick="btnApply_Click" />
    <asp:Button ID="btnDisplayAll" runat="server" style="z-index: 1; width: 119px" Text="Display All" OnClick="btnDisplayAll_Click"/>
    <br />
    <br />
    <asp:Button ID="btnAdd" runat="server" style="z-index: 1; " Text="Add" height="30px" width="80px" OnClick="btnAdd_Click"  />
    <asp:Button ID="btnEdit" runat="server" style="z-index: 1; " Text="Edit" height="30px" width="80px" OnClick="btnEdit_Click" />
    <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; right: 249px" Text="Delete" height="30px" width="80px"/>
    
</asp:Content>

