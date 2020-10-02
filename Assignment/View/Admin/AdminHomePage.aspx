<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="Assignment.View.Admin.AdminHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="logout" runat="server" OnClick="logout_Click" Text="Log Out" Height="29px" Width="102px" />

    <br /><br /><br />
    <asp:Label ID="welTxt" runat="server"></asp:Label>
    <br />
    <asp:Button runat="server" ID="viewproduct" Text="View Product" OnClick="viewproduct_Click"/>
    <asp:Button runat="server" ID="viewproducttype" Text="View Product Type" OnClick="viewproducttype_Click"/>
    <asp:Button runat="server" ID="viewuser" Text="View User" OnClick="viewUser_Click"/>
</asp:Content>

