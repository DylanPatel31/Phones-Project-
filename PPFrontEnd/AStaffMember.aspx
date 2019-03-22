<%@ Page Title="" Language="C#" MasterPageFile="~/Phones.Master" AutoEventWireup="true" CodeBehind="AStaffMember.aspx.cs" Inherits="PPFrontEnd.AStaffMember" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
   <asp:Label ID="lblTitle" runat="server" Text="Title" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtTitle" runat="server" style="z-index: 1; "></asp:TextBox>
            <br />
            <asp:Label ID="lblFirstName" runat="server" Text="First Name" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtFirstName" runat="server" Width="220px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblLastName" runat="server"  Text="Last Name" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtLastName" runat="server" Width="220px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date Of Birth" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtDateOfBirth" runat="server" Width="220px" ></asp:TextBox>
            <br /> 
            <asp:Label ID="lblAddress1" runat="server" Text="Address 1" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtAddress1" runat="server" Width="220px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblAddress2" runat="server" Text="Address 2" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtAddress2" runat="server" Width="220px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblCity" runat="server" Text="City" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtCity" runat="server" Width="220px" ></asp:TextBox>
            <br />
            <asp:Label ID="lblPostCode" runat="server" Text="Post Code" Width="200px"></asp:Label>
            &nbsp;<asp:TextBox ID="txtPostCode" runat="server" Width="220px" ></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ></asp:Label>            
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" height="30px" Text="OK" width="80px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1;" Text="Cancel" height="30px" width="80px" OnClick="btnCancel_Click" />
</asp:Content>
