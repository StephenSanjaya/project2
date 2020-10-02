<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Assignment.View.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Home Page</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br /><br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button runat="server" Text="Login" ID="login" OnClick="login_Click" Height="50px" Width="250px"/>
    </div>
    <div>
        <br /><br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button runat="server" Text="Register" ID="register" OnClick="register_Click" Height="50px" Width="250px"/>
    </div>
    <div>
        <br /><br /><br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button runat="server" Text="View Product" ID="view" OnClick="view_Click" Height="50px" Width="250px"/>
    </div>
</asp:Content>


