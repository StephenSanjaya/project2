<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="DeleteProductPage.aspx.cs" Inherits="Assignment.View.Admin.DeleteProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button runat="server" ID="back" Text="Back" OnClick="back_Click"/>
    <br />
    <asp:GridView runat="server" ID="_allproduct" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField HeaderText="ProductID" DataField="productid"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="ProductTypeID" DataField="producttypeid"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="ProductName" DataField="productname"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="Price" DataField="price"/>
        </Columns>
        <Columns>
            <asp:BoundField HeaderText="Stock" DataField="stock"/>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Table runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label runat="server">ID product you want to delete</asp:Label>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:TextBox runat="server" ID="id"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button runat="server" ID="deleteproduct" Text="Delete" OnClick="deleteproduct_Click"/>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
