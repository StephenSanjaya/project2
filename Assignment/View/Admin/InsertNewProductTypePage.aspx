<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="InsertNewProductTypePage.aspx.cs" Inherits="Assignment.View.Admin.InsertNewProductTypePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" ID="back" OnClick="back_Click" Text="Back"/>
    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Product Type</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="producttype"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Description</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="description"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" ID="updateproducttype" Text="Update" OnClick="updateproducttype_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
