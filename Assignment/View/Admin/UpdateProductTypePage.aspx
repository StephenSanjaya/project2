<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="UpdateProductTypePage.aspx.cs" Inherits="Assignment.View.Admin.UpdateProductTypePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" ID="text" Text="Back" OnClick="text_Click"/>
    <br />
    <asp:GridView runat="server" ID="_prodtype"></asp:GridView>
    <br />
    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">ID you want to update</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="id"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:Button runat="server" ID="newproducttype" Text="Update" OnClick="newproducttype_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
