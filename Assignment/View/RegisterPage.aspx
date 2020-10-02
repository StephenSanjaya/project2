<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Assignment.View.RegisterPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div style="margin-left: 120px"> <br /><br /><br /><br /><br />
            <asp:Table runat="server" style="margin-left: 0px" Height="219px" Width="301px">
                <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" >Username</asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="UsernameField"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
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
                <asp:TableCell>
                    <asp:Label runat="server">Confirm Password</asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox runat="server" ID="confirm_password" TextMode="Password"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" >Gender</asp:Label>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:RadioButton runat="server" GroupName="gender" Text="Male" ID="RB1"></asp:RadioButton>
                    <asp:RadioButton runat="server" GroupName="gender" Text="Female" ID="RB2"></asp:RadioButton>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button Text="Submit" ID="registerbutton" runat="server" OnClick="registerbutton_Click"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        </div>
        <p style="margin-left: 240px" >Already have an account? <a href="LoginPage.aspx">Sign in</a></p>
</asp:Content>
