<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ChangePasswordPage.aspx.cs" Inherits="Assignment.View.Member.ChangePasswordPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" ID="back" Text="Back" OnClick="back_Click"/>
    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Old Password</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="oldpassword"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">New Password</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="newpassword" TextMode="Password"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Confirm Password</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="confirmpassword" TextMode="Password"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" Text="Change" ID="updatebutton" OnClick="changebutton_Click"></asp:Button>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
