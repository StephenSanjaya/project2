<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Assignment.View.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;
    <asp:Table runat="server" Height="126px" Width="387px">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" >Email</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="EmailField"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server" >Password</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="PasswordField" TextMode="Password"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:CheckBox ID="remember" runat="server" Text="Remember Me" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:Button  Text="Submit" ID="LoginButton" runat="server" OnClick="LoginButton_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
        <p style="margin-left: 120px">Create an account? <a href="RegisterPage.aspx">Sign up</a></p>
</asp:Content>
