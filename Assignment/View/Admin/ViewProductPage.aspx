<%@ Page Title="" Language="C#" MasterPageFile="~/View/MainPage.Master" AutoEventWireup="true" CodeBehind="ViewProductPage.aspx.cs" Inherits="Assignment.View.Admin.ViewProductPage" %>
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
    <asp:Button ID="insertproduct" runat="server" OnClick="insertproduct_Click" Text="Insert Product" Height="37px" Width="158px"/>
    <asp:Button ID="updateProduct" runat="server" OnClick="updateProduct_Click" Text="Update Product" Height="37px" Width="158px"/>
    <asp:Button ID="deleteproduct" runat="server" OnClick="deleteproduct_Click" Text="Delete Product" Height="37px" Width="158px"/>
</asp:Content>
