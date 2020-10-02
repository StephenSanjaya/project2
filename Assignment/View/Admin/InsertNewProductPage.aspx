<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="InsertNewProductPage.aspx.cs" Inherits="Assignment.View.Admin.InsertNewProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" ID="back" OnClick="back_Click" Text="Back"/>
    <br />
    <asp:GridView runat="server" ID="prodtypetable"></asp:GridView>
    <br />    
    <asp:Table runat="server" Height="159px" Width="261px">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Product Name</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="productname"></asp:TextBox>
            </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Product Type ID</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="producttypeid"></asp:TextBox>
            </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Stock</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="productstock"></asp:TextBox>
            </asp:TableCell>
    </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">Price</asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="productprice"></asp:TextBox>
            </asp:TableCell>
    </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell></asp:TableCell>
            <asp:TableCell>
                <asp:Button Text="Update" ID="updateproduct" runat="server" OnClick="updateproduct_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
