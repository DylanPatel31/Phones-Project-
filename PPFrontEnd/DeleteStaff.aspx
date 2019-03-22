<%@ Page Title="" Language="C#" MasterPageFile="~/Phones.Master" AutoEventWireup="true" CodeBehind="DeleteStaff.aspx.cs" Inherits="PPFrontEnd.DeleteStaff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
            <asp:Label ID="lblStaffNo" runat="server" style="z-index: 1; width: 323px;" Text="Are you sure you want to delete this address?"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnYes" runat="server" style="z-index: 1; width: 80px" height="30px" Text="Yes" OnClick="btnYes_Click" />
            <asp:Button ID="btnNo" runat="server" height="30px" style="z-index: 1;" Text="No" width="80px" OnClick="btnNo_Click" />
</asp:Content>
