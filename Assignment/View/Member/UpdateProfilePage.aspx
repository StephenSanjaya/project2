<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="UpdateProfilePage.aspx.cs" Inherits="Assignment.View.Member.UpdateProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" ID="back" Text="Back" OnClick="back_Click"/>
    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Email</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="emailfield" SkinID></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Name</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="namefield"></asp:TextBox>
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
                <asp:Button runat="server" ID="updateprofile" Text="Update Profile" OnClick="updateprofile_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
